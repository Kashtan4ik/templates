using System.Web.Http;

namespace Template.Api {
    public class SomeController : ApiController {
        [HttpGet]
        [ActionName("some-get")]
        public string Get() {
            return "some-result";
        }
    }
}