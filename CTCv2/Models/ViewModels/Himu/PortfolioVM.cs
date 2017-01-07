using Umbraco.Core.Models;

namespace CTCv2.Models.ViewModels.Himu
{
    public class PortfolioVM : IPanel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Order { get; set; }
        public string MenuTitle { get; set; }
        public bool HasMenuItem { get; set; }

        public PortfolioVM(IPublishedContent content)
        { 
            Id = content.Id;
            Title = content.GetProperty("title").DataValue.ToString();
            Text = content.GetProperty("text").DataValue.ToString();
            MenuTitle = content.GetProperty("menuTitle").DataValue.ToString();
            HasMenuItem = content.GetProperty("haveMenuItem").DataValue.ToString()=="1";
            Order = content.SortOrder;
        }

        public void ContentToPanel(IPublishedContent content)
        {
            Id = content.Id;
            Title = content.GetProperty("title").DataValue.ToString();
            Text = content.GetProperty("title").DataValue.ToString();
            Order = content.SortOrder;
        }
    }
}