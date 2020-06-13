using System;

namespace PiggyBank.Common.Commands.Operations
{
    public class AddPlanOperationCommand : AddBudgetOperationCommand
    {
        public DateTime PlanDate { get; set; }
    }
}
