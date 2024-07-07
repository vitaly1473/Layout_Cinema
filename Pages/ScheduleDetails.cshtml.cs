// Pages/SheduleDetails.cshtml.cs

using Layout_Cinema.Models;
using Layout_Cinema.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Layout_Cinema.Pages
{
    public class SheduleDetailsModel : PageModel
    {
        private readonly ScheduleService scheduleService_;

        public Schedule Schedule { get; set; }

        public SheduleDetailsModel(ScheduleService scheduleService)
        {
            scheduleService_ = scheduleService;
        }
        public void OnGet(int id)
        {           
            Schedule = scheduleService_.GetScheduleById(id);
        }
       
    }
}
