using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApplication.Models;
using FirstWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FirstWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileHumanService HumanService;
        public IEnumerable<Human> Humans { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileHumanService humanService)
        {
            _logger = logger;
            HumanService = humanService;
        }

        public void OnGet()
        {
            Humans = HumanService.GetHumans();
        }
    }
}
