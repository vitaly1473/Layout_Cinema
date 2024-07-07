using Layout_Cinema.Models;
using Layout_Cinema.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Layout_Cinema.Pages
{
    public class AboutModel : PageModel
    {
        private readonly Films film_;

        public string Message { get; }
        public List<Movie> Movies => film_.Movies;

        public AboutModel(Films film)
        {
            film_ = film;
            Message = "Enjoy watching!";
        }
        public string PrintTime() => DateTime.Now.ToShortTimeString();
        public void OnGet()
        {
        }
    }
}
