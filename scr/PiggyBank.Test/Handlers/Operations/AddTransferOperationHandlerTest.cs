using Microsoft.EntityFrameworkCore;
using PiggyBank.Common.Commands.Operations;
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
    public class AddTransferOperationHandlerTest : IDisposable
    {
        public readonly PiggyContext _context;
        public AddTransferOperationHandlerTest()
            => _context = new PiggyContext(new DbContextOptionsBuilder<PiggyContext>()
                .UseInMemoryDatabase(databaseName: "TransferOperation_InMemory").Options);

        [Theory]
        [InlineData(100, 200, 100)]
        [InlineData(200, 100, -100)]
        [InlineData(200, 200, 0)]
        public async Task Invoke_ByDefault(decimal amount, decimal fromBalance, decimal fromResult)
        {
            _context.Accounts.AddRange(new[]
            {
                new Account{ Id = 1, Balance = fromBalance },
                new Account{ Id =2 }
            });
            _context.SaveChanges();

            var command = new AddTransferOperationCommand
            {
                Amount = amount,
                From = 1,
                To = 2
            };

            await new AddTransferOperationHandler(_context, command)
                .Invoke(CancellationToken.None);

            Assert.Equal(fromResult, _context.Accounts.First(a => a.Id == 1).Balance);
        }

        [Fact]
        public async Task Invoke_FromIdIsInvalid_ThrowsException()
        {
            var command = new AddTransferOperationCommand
            {
                Amount = 100,
                From = 1,
                To = 2
            };

            var handler = new AddTransferOperationHandler(_context, command);

            await Assert.ThrowsAsync<ArgumentException>(() => handler.Invoke(CancellationToken.None));
        }

        [Fact]
        public async Task Invoke_ToIdIsInvalid_ThrowsException()
        {
            _context.Accounts.AddRange(new[]
            {
                new Account{ Id = 1 }
            });
            _context.SaveChanges();

            var command = new AddTransferOperationCommand
            {
                Amount = 100,
                From = 1,
                To = 2
            };

            var handler = new AddTransferOperationHandler(_context, command);

            await Assert.ThrowsAsync<ArgumentException>(() => handler.Invoke(CancellationToken.None));
        }

        public void Dispose()
        {
            _context.Accounts.RemoveRange(_context.Accounts);
            _context.Operations.RemoveRange(_context.Operations);
            _context.SaveChanges();
            _context.Dispose();
        }
    }
}
