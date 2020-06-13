using PiggyBank.Common.Enums;

namespace PiggyBank.Common.Commands.Categories
{
    public class AddCategoryCommand : BaseCreateCommand
    {
        public string Title { get; set; }

        public string HexColor { get; set; }

        public CategoryType Type { get; set; }
    }
}
