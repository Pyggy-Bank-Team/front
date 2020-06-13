using System;
using System.ComponentModel.DataAnnotations;

namespace PiggyBank.Model.Models.Entities
{
    public class PlanOperation : BudgetOperation
    {
        [Required]
        public DateTime PlanDate { get; set; }
    }
}
