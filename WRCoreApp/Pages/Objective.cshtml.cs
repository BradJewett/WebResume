using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WRCoreApp.Pages
{
    public class ObjectiveModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ObjectiveModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
