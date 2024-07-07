// file Pages/index.cshtml.cs
using Layout_Cinema.Models;
using Layout_Cinema.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Layout_Cinema.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ScheduleService scheduleService_;

        public List<Schedule> Schedule { get; set; }

        public IndexModel(ScheduleService scheduleService)
        {
            scheduleService_ = scheduleService;
        }
        public void OnGet()
        {
            Schedule = scheduleService_.Schedules;
        }
    }
}
