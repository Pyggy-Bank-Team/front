using System.ComponentModel;

namespace Funtik.Enums
{
    public enum CategoryType
    {
        [Description("Undefined")]
        Undefined = 0,

        [Description("Income")]
        Income,

        [Description("Expense")]
        Expense
    }
}
