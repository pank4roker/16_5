using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _16_5
{
    /// <summary>
    /// Класс описывающий посещение сайта 
    /// </summary>
    class Web_site
    {
        /// <summary>
        /// адрес открытой web-странички
        /// </summary>
        private string address;
        public string Address { get => address; set => address = value; }
        /// <summary>
        /// ip-адрес посетителя;
        /// </summary>
        private string ip;
        public string Ip { get => ip; set => ip = value; }
        /// <summary>
        ///  web-браузер посетителя
        /// </summary>
        private string browser;
        public string Browser { get => browser; set => browser = value; }
        /// <summary>
        /// дата визита
        /// </summary>
        private DateTime datevisit;
        public DateTime Datevisit { get => datevisit; set => datevisit = value; }
        /// <summary>
        /// время визита
        /// </summary>
        private DateTime timevisit;
        public DateTime Timevisit { get => timevisit; set => timevisit = value; }
        /// <summary>
        /// Конструктор без параметров 
        /// </summary>
        public Web_site() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        public Web_site(string address, string ip,string browser,DateTime datevisit, DateTime timevisit )
        {
            this.Address = address;
            this.Ip = ip;   
            this.Browser = browser;
            this.Datevisit = datevisit;
            this.Timevisit = timevisit;
        }
        public void ShowInfo()
        {
            WriteLine($"Адрес:{Address}\nIP-адрес:{Ip}\nБраузер:{Browser}\nДата визита:{Datevisit.ToString("D")}\nВремя визита:{Timevisit.ToString("T")}\n");
        }
       



    }
}
