// Models/Schedule.cs
// добавили в проект класс Schedule / Расписание сеансов фильмов

namespace Layout_Cinema.Models
{
    public class Schedule
    {
        public int Id_ { get; set; } // id сеанса фильма
        public DateTime Date_ { get; set; } // дата сеанса
        public DateTime Time_ { get; set; } // время сеанса
        public string Name_ { get; set; } // название фильма
        public int Price_ { get; set; } // цена билета

        // конструктор, принимающий 5 аргументов
        public Schedule(int id, DateTime date, DateTime time, string name, int price)
        {
            Id_ = id;
            Date_ = date;
            Time_ = time;
            Name_ = name;
            Price_ = price;
        }
    }
}
// 24 lines of code 