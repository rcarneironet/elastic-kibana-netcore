using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace ElasticKibanaNetCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            try
            {
                throw new Exception("Ops, não foi possível prosseguir.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Seu código está bugado!");
            }
        }
    }
}
