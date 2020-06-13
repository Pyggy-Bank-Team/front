using System.Collections.Generic;

namespace PiggyBank.WebSite.Models.Components
{
    public class NavigationLinkModel
    {
        public string Href { get; set; }

        public string LinkText { get; set; }

        public string ImgClass { get; set; }

        public bool IsSelected { get; set; }

        public bool IsChild { get; set; }

        public List<NavigationLinkModel> SubnavigationLinks { get; set; }
    }
}
