using CTCv2.Code.Helpers;
using System.Collections.Generic;
using Umbraco.Core.Models;

namespace CTCv2.Models.ViewModels.Himu
{
    public class OurTeamVM : IPanel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Order { get; set; }
        public List<OurTeamPanelVM> TeamMembers { get; set; }
        public string MenuTitle { get; set; }
        public bool HasMenuItem { get; set; }

        public OurTeamVM(IPublishedContent content)
        { 
            Id = content.Id;
            Title = content.GetProperty("title").DataValue.ToString();
            Text = content.GetProperty("text").DataValue.ToString();
            MenuTitle = content.GetProperty("menuTitle").DataValue.ToString();
            HasMenuItem = content.GetProperty("haveMenuItem").DataValue.ToString()=="1";
            Order = content.SortOrder;


            TeamMembers = new List<OurTeamPanelVM>();
            foreach (var child in content.Children)
            {
                TeamMembers.Add(new OurTeamPanelVM(child));
            }
            
        }

    }


    public class OurTeamPanelVM 
    {

        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }


        public OurTeamPanelVM(IPublishedContent content)
        {
            Title = content.GetProperty("title").DataValue.ToString();
            SubTitle = content.GetProperty("subTitle").DataValue.ToString();
            Text = content.GetProperty("text").DataValue.ToString();
            Image = MediaHelpers.GetMediaURL(content.GetProperty("image").DataValue.ToString());
        }

    }
}