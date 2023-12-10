using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WRCoreApp.Pages
{
    public class SkillsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public SkillsModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
