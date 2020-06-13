namespace PiggyBank.Common.Commands.Operations
{
    public class AddBudgetOperationCommand : BaseCreateCommand
    {
        public int CategoryId { get; set; }

        public decimal Amount { get; set; }

        public int AccountId { get; set; }

        public string Comment { get; set; }
    }
}
