namespace PiggyBank.Model.Models.Entities
{
    public class TransferOperation : Operation
    {
        /// <summary>
        /// From account
        /// </summary>
        public int From { get; set; }

        /// <summary>
        /// To account
        /// </summary>
        public int To { get; set; }

        public decimal Amount { get; set; }
    }
}
