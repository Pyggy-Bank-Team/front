using System.ComponentModel.DataAnnotations;

namespace PiggyBank.Common.Models.Dto
{
    public class TransferOperationDto
    {
        [Range(0, int.MaxValue)]
        public int From { get; set; }

        [Range(0, int.MaxValue)]
        public int To { get; set; }

        [Required]
        public decimal? Amount { get; set; }

        public string Comment { get; set; }
    }
}
