﻿using System.ComponentModel.DataAnnotations;
using Funtik.Enums;

namespace Funtik.Models.Services.Requests
{
    public class AccountDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title can't be empty")]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        public AccountType Type { get; set; }

        public string Currency { get; set; }

        public decimal Balance { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsArchived { get; set; }
    }
}
