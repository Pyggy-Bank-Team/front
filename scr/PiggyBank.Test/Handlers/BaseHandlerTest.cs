using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PiggyBank.Domain.Handler;
using PiggyBank.Model;
using PiggyBank.Model.Interfaces;
using PiggyBank.Model.Models.Entities;
using Xunit;

namespace PiggyBank.Test.Handlers
{
    public class BaseHandlerTest : IDisposable
    {
        private readonly PiggyContext _context;

        public BaseHandlerTest()
            => _context = new PiggyContext(new DbContextOptionsBuilder<PiggyContext>()
                .UseInMemoryDatabase(databaseName: "PiggyBank_InMemory")
                .Options);

        [Fact]
        public void GetRepository_Normal_EntityFound()
        {
            using var handler = new TestHandler(new object(), _context);
            var repository = handler.GetRepository<Operation>();
            Assert.NotNull(repository);
        }

        [Fact]
        public void GetRepository_EntityNotExists_ThrowsException()
        {
            using var handler = new TestHandler(new object(), _context);
            var temp = handler.GetRepository<TestModel>();
            Assert.Throws<InvalidOperationException>(() => { temp.CountAsync(); });
        }

        public void Dispose()
            => _context.Dispose();
    }

    public class TestHandler : BaseHandler<object>
    {
        public TestHandler(object obj, PiggyContext context) : base(context, obj) { }
        public override Task Invoke(CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }

    public class TestModel : IBaseModel
    {
        public int Id { get; set; }
    }
}
