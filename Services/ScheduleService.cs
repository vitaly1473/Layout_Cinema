// Services/ScheduleService.cs
// создание сервиса для управления расписанием сеансов фильмов/ Инициализация сеансов фильмов

using System.Collections.Generic;
using Layout_Cinema.Models;

namespace Layout_Cinema.Services
{
    public class ScheduleService
    {
        public List<Schedule> Schedules { get; }
        public ScheduleService()
        {
        Schedules = new List<Schedule>
        {
            new Schedule(1, new DateTime(2024, 07, 07), new DateTime(2024, 07, 07, 15, 30, 0), "Bridget Jones's Diary", 500),
            new Schedule(2, new DateTime(2024, 07, 08), new DateTime(2024, 07, 08, 18, 0, 0), "Social network", 600),
            new Schedule(3, new DateTime(2024, 07, 09), new DateTime(2024, 07, 09, 20, 0, 0), "The Art of Self-Defense", 700),
            new Schedule(4, new DateTime(2024, 07, 10), new DateTime(2024, 07, 10, 10, 0, 0), "The Bronze  bird", 400),
            new Schedule(5, new DateTime(2024, 07, 10), new DateTime(2024, 07, 10, 11, 0, 0), "Adventure Electronics", 450),
            new Schedule(6, new DateTime(2024, 07, 12), new DateTime(2024, 07, 12, 21, 0, 0), "The Terminator", 750)
        };
        }
        public Schedule GetScheduleById(int id)
        {  // 1 вариант
            foreach (var schedule_ in Schedules)
            {
                if (schedule_.Id_ == id)
                {
                    return schedule_;
                }
            }
            return null; // возвращает null, если сеанс фильма  с указанным id не найден
            
            // 2 вариант 
            //return Schedules.FirstOrDefault(s => s.Id_ == id);
        }
    }
}
// 39 lines of code 
