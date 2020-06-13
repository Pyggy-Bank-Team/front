using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PiggyBank.Common.Enums;
using PiggyBank.Domain.Handler.Operations;
using PiggyBank.Domain.Models.Operations;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace PiggyBank.Test.Handlers.Operations
{
    public class DeleteBudgetOperationHanlderTest : IDisposable
    {
        private readonly PiggyContext _context;
        public DeleteBudgetOperationHanlderTest()
            => _context = new PiggyContext(new DbContextOptionsBuilder<PiggyContext>()
                .UseInMemoryDatabase(databaseName: "DeleteBudgetOperation_InMemory").Options);

        [Theory]
        [InlineData(100, -100, CategoryType.Income)]
        [InlineData(200, 200, CategoryType.Expense)]
        public async Task Invoke_ByDefault(decimal amount, decimal resultBalance, CategoryType categoryType)
        {
            _context.Accounts.Add(new Account { Id = 1 });
            _context.BudgetOperations.Add(new BudgetOperation
            {
                Id = 1,
                AccountId = 1,
                Amount = amount,
                CategoryId = 1,
                IsDeleted = false,
                Shapshot = JsonConvert.SerializeObject(new OperationSnapshot { CategoryType = categoryType })
            });
            _context.SaveChanges();

            await new DeleteBudgetOperationHanlder(_context, 1).Invoke(CancellationToken.None);
            _context.SaveChanges();

            var operation = await _context.BudgetOperations.FirstAsync();
            var account = await _context.Accounts.FirstAsync();

            Assert.True(operation.IsDeleted);
            Assert.Equal(resultBalance, account.Balance);
        }

        [Fact]
        public async Task Invoke_AccountIsDeleted_BalanceNotChanged()
        {
            _context.Accounts.Add(new Account { Id = 1, IsDeleted = true, Balance = 100 });
            _context.BudgetOperations.Add(new BudgetOperation
            {
                Id = 1,
                AccountId = 1,
                Amount = 100,
                CategoryId = 1,
                IsDeleted = false,
                Shapshot = JsonConvert.SerializeObject(new OperationSnapshot { CategoryType = CategoryType.Income })
            });
            _context.SaveChanges();

            await new DeleteBudgetOperationHanlder(_context, 1).Invoke(CancellationToken.None);
            _context.SaveChanges();

            var operation = await _context.BudgetOperations.FirstAsync();
            var account = await _context.Accounts.FirstAsync();

            Assert.True(operation.IsDeleted);
            Assert.Equal(100, account.Balance);
        }

        [Fact]
        public async Task Invoke_AccountIsArchived_BalanceNotChanged()
        {
            _context.Accounts.Add(new Account { Id = 1, IsArchived = true, Balance = 100 });
            _context.BudgetOperations.Add(new BudgetOperation
            {
                Id = 1,
                AccountId = 1,
                Amount = 100,
                CategoryId = 1,
                IsDeleted = false,
                Shapshot = JsonConvert.SerializeObject(new OperationSnapshot { CategoryType = CategoryType.Income })
            });
            _context.SaveChanges();

            await new DeleteBudgetOperationHanlder(_context, 1).Invoke(CancellationToken.None);
            _context.SaveChanges();

            var operation = await _context.BudgetOperations.FirstAsync();
            var account = await _context.Accounts.FirstAsync();

            Assert.True(operation.IsDeleted);
            Assert.Equal(100, account.Balance);
        }

        public void Dispose()
        {
            _context.BudgetOperations.RemoveRange(_context.BudgetOperations);
            _context.Accounts.RemoveRange(_context.Accounts);
            _context.SaveChanges();
            _context.Dispose();
        }
    }
}
