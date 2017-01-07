using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace CTCv2.Models.ViewModels
{
    public class HomeVM :RenderModel
    {
        public HomeVM(IPublishedContent content)
            : base(content)
        {

        }

        public List<IPublishedContent> Panels { get; set; }
        public List<string> PanelTitles { get; set; }
    }
}