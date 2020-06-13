namespace PiggyBank.Common.Models.Generic
{
    public class GenericGroup<TKey, TValues>
    {
        public TKey Key { get; set; }

        public TValues[] Values { get; set; }
    }
}
