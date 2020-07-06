using System.ComponentModel;

namespace Funtik.Enums
{
    public enum AccountType
    {
        [Description("Undefined")]
        Undefined = 0,

        [Description("Cash")]
        Cash,

        [Description("Card")]
        Card
    }
}
