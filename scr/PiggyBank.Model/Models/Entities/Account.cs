using PiggyBank.Common.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PiggyBank.Model.Models.Entities
{
    public class Account : DeletedEntityBase
    {
        [Required]
        public string Title { get; set; }

        public AccountType Type { get; set; }

        public string Currency { get; set; }

        public decimal Balance { get; set; }

        [InverseProperty(nameof(Account))]
        public virtual ICollection<BalanceHistory> BalanceHistories { get; set; } = new List<BalanceHistory>();

        public void ChangeBalance(decimal delta)
        {
            Balance += delta;

            BalanceHistories.Add(new BalanceHistory
            {
                Value = Balance
            });
        }
    }
}
