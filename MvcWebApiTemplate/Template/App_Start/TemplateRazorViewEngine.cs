using System.Web.Mvc;

namespace Template {
    public class TemplateRazorViewEngine : RazorViewEngine {
        public TemplateRazorViewEngine() {
            ViewLocationFormats = new string[]
            {
                "~/{1}/Views/{0}.cshtml"
            };

            PartialViewLocationFormats = new string[]
            {
                "~/Shared/Views/{0}.cshtml"
            };
        }
    }
}