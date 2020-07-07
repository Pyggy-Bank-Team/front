using System;
using System.ComponentModel.DataAnnotations;

namespace Funtik.Models.Services.Requests
{
    public class PlanOperationDto : BudgetOperationDto
    {
        [Required]
        public DateTime? PlanDate { get; set; }
    }
}
