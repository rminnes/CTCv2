using System.Globalization;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace CTCv2.Models.ViewModels.Himu
{
    public class ContactVM : RenderModel, IPanel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string ThankYouMessage { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public bool FormSent { get; set; }
        public int Order { get; set; }
        public string MenuTitle { get; set; }
        public bool HasMenuItem { get; set; }


        public ContactVM()
            : base(new UmbracoHelper(UmbracoContext.Current)
            .TypedContent(UmbracoContext.Current == null ? 0 : UmbracoContext.Current.PageId)) { }

        public ContactVM(IPublishedContent content, bool sent)
            : base(content, CultureInfo.CurrentCulture) 
        { 
            Id = content.Id;
            Title = content.GetProperty("title").DataValue.ToString();
            Text = content.GetProperty("text").DataValue.ToString();
            MenuTitle = content.GetProperty("menuTitle").DataValue.ToString();
            HasMenuItem = content.GetProperty("haveMenuItem").DataValue.ToString()=="1";
            ThankYouMessage = content.GetProperty("thankYouMessage").DataValue.ToString() ;
            Address1 = content.GetProperty("addressLine1").DataValue.ToString();
            Address2 = content.GetProperty("addressLine2").DataValue.ToString();
            Address3 = content.GetProperty("addressLine3").DataValue.ToString();
            Address4 = content.GetProperty("addressLine4").DataValue.ToString();
            Order = content.SortOrder;
            FormSent = sent;
        }


    }
}