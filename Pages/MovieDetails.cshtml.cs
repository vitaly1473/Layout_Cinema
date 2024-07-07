using Layout_Cinema.Models;
using Layout_Cinema.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Layout_Cinema.Pages
{
    public class MovieDetailsModel : PageModel
    {
        private readonly Films film_;

        public Movie Movie { get; set; }

        public MovieDetailsModel(Films film)
        {
            film_ = film;
        }
        public void OnGet(int id)
        {
            Movie = film_.GetMovieById(id);
        }
    }
}
