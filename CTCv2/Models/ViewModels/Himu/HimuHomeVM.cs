using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace CTCv2.Models.ViewModels.Himu
{
    public class HimuHomeVM : RenderModel
    {

        public HimuHomeVM(IPublishedContent content)
            : base(content)
        {

        }

        public List<IPublishedContent> Panels { get; set; }
        public List<string> PanelTitles { get; set; }
        public bool ContactFormSent { get; set; }
    
    }
}