using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _16_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            /*Write("Количество посещений:");
            int n = Convert.ToInt32(ReadLine());
            Web_site[] website=new Web_site[n];
            for (int i = 0; i < website.Length;i++)
            {
                Write("Введите адрес web-странички: ");
                string address= ReadLine();
                Write("Введите IP-адрес: ");
                string ip = ReadLine();
                Write("Введите браузер: ");
                string browser = ReadLine();
                Write("Введите дату посещения: ");
                DateTime datevisit = DateTime.Parse(ReadLine());
                Write("Введите время посещения: ");
                DateTime timevisit = DateTime.Parse(ReadLine());
                website[i] = new Web_site(address,ip,browser,datevisit,timevisit);
            }
            foreach(var elem in  website) 
            {
                elem.ShowInfo();
            }
            Write("Введите время вчерашего дня: ");
            DateTime date1 = DateTime.Parse(ReadLine());
            Write("Введите время сегодняшнего дня: ");
            DateTime date2 = DateTime.Parse(ReadLine());
            foreach (var elem in website)
            {
                if (date1 < elem.Timevisit && date2 > elem.Timevisit)
                {
                    elem.ShowInfo();
                }
            }*/
            //Task2
            House[] houses = new House[3];
            for(int i =0;i<houses.Length;i++)
            {
                Write("Введите дату включения: ");
                DateTime dateon = DateTime.Parse(ReadLine());
                Write("Введите время включения: ");
                DateTime timeon = DateTime.Parse(ReadLine());
                Write("Введите темпертатурный режим (Х или Г): ");
                string tempmode = ReadLine();
                Write("Введите температуру: ");
                int tempair = int.Parse(ReadLine());
                houses[i] = new House(dateon, timeon, tempmode, tempair);
            }
            foreach (var house in houses)
            {
                house.OutPut();
            }
            foreach (var house in houses)
            {
                house.Mode();
            }
            ReadLine();
        }
    }
}
