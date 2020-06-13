using PiggyBank.Common.Enums;

namespace PiggyBank.Common.Commands.Accounts
{
    public class AddAccountCommand : BaseCreateCommand
    {
        public string Title { get; set; }

        public AccountType Type { get; set; }

        public string Currency { get; set; }

        public decimal Balance { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsArchived { get; set; }
    }
}
