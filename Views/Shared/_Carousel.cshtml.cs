using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace StreetSnack.Views.Shared
{
    public class _Carousel : PageModel
    {
        private readonly ILogger<_Carousel> _logger;

        public _Carousel(ILogger<_Carousel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}