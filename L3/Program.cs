using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = Convert.ToInt32(Console.ReadLine());
            Week dayOfWeek = (Week)day - 1;
            int time = Convert.ToInt32(Console.ReadLine());
            Time timeOfWeek;

            string dow;
            string tow;

            switch (dayOfWeek)
            {
                case Week.Понедельник:
                    dow = "Понедельник";
                    break;
                case Week.Вторник:
                    dow = "Вторник";
                    break;
                case Week.Среда:
                    dow = "Среда";
                    break;
                case Week.Четверг:
                    dow = "Четверг";
                    break;
                case Week.Пятница:
                    dow = "Пятница";
                    break;
                case Week.Суббота:
                    dow = "Суббота";
                    break;
                case Week.Воскресенье:
                    dow = "Воскресенье";
                    break;
                default:
                    dow = "\"Неверный формат\"";
                    break;
            }

            if (time >= 7 && time <= 12)
            {
                time = 0;
            }
            else if (time >= 13 && time <= 18)
            {
                time = 1;
            }
            else if (time >= 19 && time <= 23)
            {
                time = 2;
            }
            else if (time >= 0 && time <= 6) 
            {
                time = 3;
            }

            timeOfWeek = (Time) time;

            switch (timeOfWeek)
            {
                case Time.Утро:
                    tow = "Утро";
                    break;
                case Time.День:
                    tow = "День";
                    break;
                case Time.Вечер:
                    tow = "Вечер";
                    break;
                case Time.Ночь:
                    tow = "Ночь";
                    break;
                default:
                    tow = "\"Неверный формат\"";
                    break;
            }

            Console.WriteLine("Сейчаc " + dow + ", " + tow);
        }
    }
}
