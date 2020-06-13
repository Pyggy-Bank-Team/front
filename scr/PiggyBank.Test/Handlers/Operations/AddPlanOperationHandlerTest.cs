using Microsoft.EntityFrameworkCore;
using PiggyBank.Common.Commands.Operations;
using PiggyBank.Common.Enums;
using PiggyBank.Domain.Handler.Operations;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace PiggyBank.Test.Handlers.Operations
{
    public class AddPlanOperationHandlerTest : IDisposable
    {
        private readonly PiggyContext _context;
        public AddPlanOperationHandlerTest()
            => _context = new PiggyContext(new DbContextOptionsBuilder<PiggyContext>()
                .UseInMemoryDatabase(databaseName: "PlanOperation_InMemory").Options);

        [Fact]
        public async Task Invoke_ByDefault_OperationWasAdded()
        {
            _context.Accounts.Add(new Account { Id = 1 });
            _context.Categories.Add(new Category { Id = 1 });
            _context.SaveChanges();

            var now = DateTime.Now;
            var command = new AddPlanOperationCommand
            {
                AccountId = 1,
                CategoryId = 1,
                Amount = 100,
                Comment = "Hello, world",
                PlanDate = now
            };

            await new AddPlanOperationHandler(_context, command)
                .Invoke(CancellationToken.None);

            _context.SaveChanges();

            Assert.Equal(1, _context.PlanOperations.Count());
        }

        [Fact]
        public async Task Invoke_AccountIdIsInvalid_ThrowsException()
        {
            var now = DateTime.Now;
            var command = new AddPlanOperationCommand
            {
                AccountId = 1,
                CategoryId = 1,
                Amount = 100,
                Comment = "Hello, world",
                PlanDate = now
            };

            var handler = new AddPlanOperationHandler(_context, command);

            await Assert.ThrowsAnyAsync<ArgumentException>(() => handler.Invoke(CancellationToken.None));
        }

        [Fact]
        public async Task Invoke_CategoryIdIsInvalid_ThrowsException()
        {
            _context.Accounts.Add(new Account { Id = 1 });
            _context.SaveChanges();

            var now = DateTime.Now;
            var command = new AddPlanOperationCommand
            {
                AccountId = 1,
                CategoryId = 1,
                Amount = 100,
                Comment = "Hello, world",
                PlanDate = now
            };

            var handler = new AddPlanOperationHandler(_context, command);

            await Assert.ThrowsAnyAsync<ArgumentException>(() => handler.Invoke(CancellationToken.None));
        }

        public void Dispose()
        {
            _context.Accounts.RemoveRange(_context.Accounts);
            _context.Categories.RemoveRange(_context.Categories);
            _context.Operations.RemoveRange(_context.Operations);
            _context.SaveChanges();
            _context.Dispose();
        }
    }
}
