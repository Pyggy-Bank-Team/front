using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PiggyBank.Model.Models.Entities
{
    public class BalanceHistory : EntityBase
    {
        public decimal Value { get; set; }

        [Required]
        public int AccountId { get; set; }

        [ForeignKey(nameof(AccountId))]
        public virtual Account Account { get; set; }
    }
}
