using PiggyBank.Common.Enums;

namespace PiggyBank.Model.Models.Entities
{
    public class Operation : EntityBase
    {
        public string Comment { get; set; }

        public OperationType Type { get; set; }

        public bool IsDeleted { get; set; }

        public string Shapshot { get; set; }
    }
}
