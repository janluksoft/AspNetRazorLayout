using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Web;

namespace PRazorSimple.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string sBoxInfo { get; set; }
        public string spath { get; set; }
        public int iNum { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            sBoxInfo = "Good Day, This is my description from (code behind)";
            iNum = 50;
            spath = Path.GetFullPath("/");
        }
        public void OnPost()
        {

        }

    }

}
