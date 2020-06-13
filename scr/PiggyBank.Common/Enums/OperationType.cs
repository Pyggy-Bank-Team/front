using System.ComponentModel;

namespace PiggyBank.Common.Enums
{
    public enum OperationType
    {
        [Description("Undefined")]
        Undefined = 0,

        [Description("Income and Expenses")]
        Budget = 1,

        [Description("Transfer")]
        Transfer = 2,

        [Description("The planned transaction")]
        Plan = 3
    }
}
