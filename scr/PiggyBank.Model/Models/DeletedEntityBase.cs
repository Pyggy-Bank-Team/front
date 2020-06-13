namespace PiggyBank.Model.Models
{
    public abstract class DeletedEntityBase : EntityBase
    {
        public bool IsDeleted { get; set; }

        public bool IsArchived { get; set; }
    }
}
