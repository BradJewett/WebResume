using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WRCoreApp.Pages
{
    public class ProjectModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ProjectModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
