using CTCv2.Models.ViewModels;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Models;

namespace CTCv2.Controllers
{
    public class CTCHomeController  : Umbraco.Web.Mvc.RenderMvcController
    {
        // GET: Home
        public override ActionResult Index(RenderModel model)
        {

            var kids = model.Content.Children;

            var panelsFolder = kids.FirstOrDefault(n => n.DocumentTypeAlias == "homePanels");
            var vm = new HomeVM(CurrentPage);

            if (panelsFolder != null)
            {
               
                var panels = panelsFolder.Children
                    .ToList();
                vm.Panels = panels;

                var panelTitles = panelsFolder.Children
                    .Where(p => int.Parse(p.GetProperty("haveMenuItem").DataValue.ToString()) == 1)
                    .Select(p => p.GetProperty("menuTitle").DataValue.ToString())
                    .ToList();

                vm.PanelTitles = panelTitles;

            }

            return base.Index(vm);
        }
    }
}