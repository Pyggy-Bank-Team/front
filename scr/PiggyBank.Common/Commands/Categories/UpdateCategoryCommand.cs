using PiggyBank.Common.Enums;

namespace PiggyBank.Common.Commands.Categories
{
    public class UpdateCategoryCommand
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string HexColor { get; set; }

        public CategoryType Type { get; set; }
    }
}
