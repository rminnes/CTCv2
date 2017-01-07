using CTCv2.Code.Helpers;
using CTCv2.Models.ViewModels.Himu;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Models;

namespace CTCv2.Controllers
{
    public class HimuMasterController : Umbraco.Web.Mvc.RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {

            //var mainPanels = model.Content.Children;

            //var panelsFolder = mainPanels.FirstOrDefault(n => n.DocumentTypeAlias == "himuPanels");
            //var vm = new HimuHomeVM(CurrentPage);
            //vm.ContactFormSent = false;
            //if (panelsFolder != null)
            //{

            //    var panels = panelsFolder.Children.OrderBy(p=>p.SortOrder)
            //        .ToList();
            //    vm.Panels = panels;

            //    var panelTitles = panelsFolder.Children
            //        .Where(p => int.Parse(p.GetProperty("haveMenuItem").DataValue.ToString()) == 1 && p.DocumentTypeAlias != "himuTopPanel")
            //        .Select(p => p.GetProperty("menuTitle").DataValue.ToString())
            //        .ToList();

            //    vm.PanelTitles = panelTitles;

            //}

            var vModel = ControllerHelpers.GetHomeModel(CurrentPage, model, false);

            return base.Index(vModel);
        }


        [HttpPost]
        public ActionResult SendFrom(ContactVM contacthModel)
        {
            var stridsafsfdng = "do something with the model";
            return View();
        }

    }
}