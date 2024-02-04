using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _16_5
{
    /// <summary>
    /// Класс описывающий умный дом
    /// </summary>
    class House
    {
        /// <summary>
        ///  Дата включения
        /// </summary>
        private DateTime dateon;
        public DateTime Dateon { get => dateon; set => dateon = value; }
        /// <summary>
        ///  Время включения
        /// </summary>
        private DateTime timeon;
        public DateTime Timeon { get => timeon; set => timeon = value; }
        /// <summary>
        /// Температурный режим
        /// </summary>
        private string tempmode;
        public string Tempmode { get => (tempmode == "Х"&& tempmode=="Г")? tempmode: "Unknown"; set => tempmode = value; }
        /// <summary>
        ///  Температура воздуха
        /// </summary>
        private int tempair;
        public int Tempair { get => (tempair>-50 && tempair<50)?tempair:0; set => tempair = value; }
        /// <summary>
        /// Конструктор без параметра
        /// </summary>
        public House() { }
        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="dateon"></param>
        /// <param name="timeon"></param>
        /// <param name="tempmode"></param>
        /// <param name="tempair"></param>
        public House(DateTime dateon,DateTime timeon,string tempmode,int tempair)
        {
            this.Dateon = dateon;
            this.Timeon = timeon;
            this.Tempmode = tempmode;
            this.Tempair = tempair;
        }
        /// <summary>
        /// Метод вывода 
        /// </summary>
        public void OutPut()
        {
            WriteLine($"Дата ключения:{Dateon.ToString("d")}\nВремя включения:{Timeon.ToString("t")}\nТемпературный режим:{Tempmode}\nТемпература воздуха:{Tempair}\nОсталось до включения:{(Timeon - DateTime.Now).TotalMinutes}\n");
        }
        public void Mode()
        {
            if(Dateon>DateTime.Now&& Dateon<DateTime.Now.AddDays(1))
            {
                OutPut();
            }
        }
    }
}
