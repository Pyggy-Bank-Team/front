﻿using System.ComponentModel.DataAnnotations;

namespace Funtik.Models.Services.Requests
{
    public class BudgetOperationDto
    {
        [Range(1, int.MaxValue)]
        public int AccountId { get; set; }

        [Range(1, int.MaxValue)]
        public int CategoryId { get; set; }

        [Required]
        public decimal? Amount { get; set; }

        public string Comment { get; set; }
    }
}
