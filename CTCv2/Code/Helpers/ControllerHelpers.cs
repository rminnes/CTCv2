using CTCv2.Models.ViewModels.Himu;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace CTCv2.Code.Helpers
{
    public static class ControllerHelpers
    {


        public static HimuHomeVM GetHomeModel(IPublishedContent CurrentPage, RenderModel model, bool formSent)
        {

            var mainPanels = model.Content.Children;
            var panelsFolder = mainPanels.FirstOrDefault(n => n.DocumentTypeAlias == "himuPanels");
            var vm = new HimuHomeVM(CurrentPage);
            if (panelsFolder != null)
            {

                var panels = panelsFolder.Children.OrderBy(p => p.SortOrder)
                    .ToList();
                vm.Panels = panels;

                var panelTitles = panelsFolder.Children
                    .Where(p => int.Parse(p.GetProperty("haveMenuItem").DataValue.ToString()) == 1 && p.DocumentTypeAlias != "himuTopPanel")
                    .Select(p => p.GetProperty("menuTitle").DataValue.ToString())
                    .ToList();

                vm.PanelTitles = panelTitles;
            }
            vm.ContactFormSent = formSent;

            return vm;

        }

    }
}