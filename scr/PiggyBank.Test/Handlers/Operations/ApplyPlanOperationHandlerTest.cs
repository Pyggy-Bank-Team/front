using Microsoft.EntityFrameworkCore;
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
    public class ApplyPlanOperationHandlerTest : IDisposable
    {
        private readonly PiggyContext _context;

        public ApplyPlanOperationHandlerTest()
        {
            var options = new DbContextOptionsBuilder<PiggyContext>().EnableSensitiveDataLogging()
               .UseInMemoryDatabase(databaseName: "ApplyPlanOperation_InMemory").Options;
            _context = new PiggyContext(options);
        }

        public async Task Invoke_ByDefault()
        {
            _context.PlanOperations.Add(new PlanOperation
            {
                Id = 1,
                IsDeleted = false,
                Amount = 100,
                CategoryId = 1,
                AccountId = 1,
                Comment = "Hello, world",
                CreatedBy = Guid.NewGuid(),
                CreatedOn = DateTime.Now,
                PlanDate = DateTime.Now.AddDays(2),
                Type = OperationType.Plan
            });
            _context.SaveChanges();

            await new ApplyPlanOperationHandler(_context, 1).Invoke(CancellationToken.None);
            _context.SaveChanges();

            var planOperation = _context.PlanOperations.First(p => p.Id == 1);
            var budgetOperation = _context.BudgetOperations.First();

            Assert.True(planOperation.IsDeleted);
            Assert.Equal(planOperation.Amount, budgetOperation.Amount);
            Assert.Equal(planOperation.CategoryId, budgetOperation.CategoryId);
            Assert.Equal(planOperation.AccountId, budgetOperation.AccountId);
            Assert.Equal(planOperation.Comment, budgetOperation.Comment);
        }

        [Fact]
        public async Task Invoke_PlanOperationIdIsInvalid_ThrowsException()
        {
            var handler = new ApplyPlanOperationHandler(_context, 1);
            await Assert.ThrowsAsync<ArgumentException>(() => handler.Invoke(CancellationToken.None));
        }

        public void Dispose()
        {
            _context.PlanOperations.RemoveRange(_context.PlanOperations);
            _context.BudgetOperations.RemoveRange(_context.BudgetOperations);
            _context.Dispose();
        }
    }
}
