using Funtik.Enums;

namespace Funtik.Models.Requests
{
    public class AccountInfoDto
    {
        public int Id { get; set; }

        public AccountType Type { get; set; }

        public string Title { get; set; }

        public string Currency { get; set; }

        public decimal Balance { get; set; }

        public bool IsArchived { get; set; }
    }
}
