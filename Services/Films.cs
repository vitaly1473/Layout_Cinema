// Services/MovieService.cs
// добавили в проект класс Films
using System.Collections.Generic;
using Layout_Cinema.Models;

namespace Layout_Cinema.Services
{
    public class Films
    {
    public List<Movie> Movies { get; }
    public Films() //инициализация фильмов
    {
        Movies = new List<Movie>
        {
            new Movie(1, "Bridget Jones's Diary", "Sharon Maguire", "Бриджит Джонс заводит дневник, чтобы описывать свои достижения и победы", 2001),
            new Movie(2, "Social network", "David Fincher", "Студента Гарварда Марка Цукерберга бросает его девушка...", 2010),
            new Movie(3, "The Art of Self-Defense", "Райли Стернс", "Стеснительный 35-летний бухгалтер с женственным именем Кэйси Дэвис как-то ночью отправляется за собачьим кормом...", 2018),
            new Movie(4, "The Bronze Bird", "Анатолий Рыбаков", "1920-е. Дети ищут сокровища, секрет которых хранит бронзовая статуэтка хищной птицы...", 1974),
            new Movie(5, "The Adventures of Electronics", "Константин Бромберг", "Советский ученый создает гениального робота. Это мальчик, который способен решать любые математические задачи...", 1979),
            new Movie(6, "Терминатор", "Джеймс Кэмерон", "История противостояния солдата Кайла Риза и киборга-терминатора, прибывших в 1984 год из пост-апокалиптического будущего, где миром правят машины-убийцы, " +
            "а человечество находится на грани вымирания.", 1984)
        };            
    }
        // метод GetMovieById возвращает объект типа Movie, который является моделью фильма
        public Movie GetMovieById(int id)
        {
            foreach (var movie in Movies)
            {
                if (movie.Id_ == id)
                {
                    return movie;
                }
            }
            return null; // возвращает null, если фильм с указанным id не найден

            // 2 вариант 
            //return Movies.FirstOrDefault(m => m.Id_ == id);
        }
    }
}
// 41 lines of code 
