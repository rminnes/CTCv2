using CTCv2.Code;
using CTCv2.Code.Helpers;
using CTCv2.Models.ViewModels.Himu;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace CTCv2.Controllers
{
    public class ContactController  : SurfaceController
    {
        // GET: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendForm(ContactVM model)
        {

            var cRepo = new ContactRepo();

            cRepo.AddContactDetails(model.Name, model.Email, model.Message);

            var template = UmbracoContext.Application.Services.FileService.GetTemplate(CurrentPage.TemplateId);
            var path = template.VirtualPath;

            return View(path, ControllerHelpers.GetHomeModel(CurrentPage,model, true));
        }
    }
}