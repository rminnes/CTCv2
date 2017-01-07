
using CTCv2.Code.Helpers;
using Umbraco.Core.Models;
using Umbraco.Web.Models;
namespace CTCv2.Models.ViewModels.Himu
{
    public class TopPanelVM:RenderModel,  IPanel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Order { get; set; }
        public string MenuTitle { get; set; }
        public bool HasMenuItem { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public string ButtonText { get; set; }

        public TopPanelVM(IPublishedContent content)
            : base(content)
        { 
            Id = content.Id;
            Title = content.GetProperty("title").DataValue.ToString();
            Text = content.GetProperty("text").DataValue.ToString();
            MenuTitle = content.GetProperty("menuTitle").DataValue.ToString();
            HasMenuItem = content.GetProperty("haveMenuItem").DataValue.ToString()=="1";
            Order = content.SortOrder; 
            SubTitle = content.GetProperty("subTitle").DataValue.ToString();

            //var mediaFile = ApplicationContext.Current.Services.MediaService.GetById(int.Parse(content.GetProperty("backgroundImage").DataValue.ToString()));
            //var url = mediaFile.GetValue("umbracoFile").ToString().Split('\'')[1];
            //umbraco.uQuery.GetMedia(content.GetProperty("backgroundImage").DataValue.ToString()).Image;//GetImageUrlById(content.GetProperty("backgroundImage").DataValue.ToString());//;


            Image = MediaHelpers.GetMediaURL(content.GetProperty("backgroundImage").DataValue.ToString()); 
            Link = content.GetProperty("link").DataValue.ToString();
            ButtonText = content.GetProperty("buttonText").DataValue.ToString();

        }







    }


}