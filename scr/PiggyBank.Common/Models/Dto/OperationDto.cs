using PiggyBank.Common.Enums;
using System;

namespace PiggyBank.Common.Models.Dto
{
    public class OperationDto
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string CategoryHexColor { get; set; }

        public decimal Amount { get; set; }

        public int AccountId { get; set; }

        public string AccountTitle { get; set; }

        public string Comment { get; set; }

        public OperationType Type { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? PlanDate { get; set; }

        public string FromTitle { get; set; }

        public string ToTitle { get; set; }
    }
}
