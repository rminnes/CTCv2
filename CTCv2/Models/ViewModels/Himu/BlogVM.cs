using System.Collections.Generic;
using Umbraco.Core.Models;

namespace CTCv2.Models.ViewModels.Himu
{
    public class BlogVM : IPanel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Order { get; set; }
        public string MenuTitle { get; set; }
        public bool HasMenuItem { get; set; }

        public List<BlogPanelVM> BlogItems { get; set; }

        public BlogVM(IPublishedContent content)
        { 
            Id = content.Id;
            Title = content.GetProperty("title").DataValue.ToString();
            Text = content.GetProperty("text").DataValue.ToString();
            MenuTitle = content.GetProperty("menuTitle").DataValue.ToString();
            HasMenuItem = content.GetProperty("haveMenuItem").DataValue.ToString()=="1";
            Order = content.SortOrder;


            BlogItems = new List<BlogPanelVM>();
            foreach (var child in content.Children)
            {

                BlogItems.Add(new BlogPanelVM(child));

            }

        }

    }
}