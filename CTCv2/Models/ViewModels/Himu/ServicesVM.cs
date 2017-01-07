using CTCv2.Code.Helpers;
using System.Collections.Generic;
using Umbraco.Core.Models;

namespace CTCv2.Models.ViewModels.Himu
{
    public class ServicesVM : IPanel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public int Order { get; set; }
        public List<ServicesPanelVM> Services { get; set; }
        public string MenuTitle { get; set; }
        public bool HasMenuItem { get; set; }

        public ServicesVM(IPublishedContent content)
        { 
            Id = content.Id;
            Title = content.GetProperty("title").DataValue.ToString();
            Text = content.GetProperty("text").DataValue.ToString();
            Image = MediaHelpers.GetMediaURL(content.GetProperty("image").DataValue.ToString());    
            MenuTitle = content.GetProperty("menuTitle").DataValue.ToString();
            HasMenuItem = content.GetProperty("haveMenuItem").DataValue.ToString()=="1";
            Order = content.SortOrder;

            Services = new List<ServicesPanelVM>();
            foreach (var child in content.Children)
            {
                Services.Add(new ServicesPanelVM(child));
            }

        }

    }

    public class ServicesPanelVM {

        public string Title { get; set; }
        public string Text { get; set; }
        public string FAIcon { get; set; }

        public ServicesPanelVM(IPublishedContent content)
        {
            Title = content.GetProperty("title").DataValue.ToString();
            Text = content.GetProperty("text").DataValue.ToString();
            FAIcon = content.GetProperty("fontAwesomeIcon").DataValue.ToString();
        }

    }

}