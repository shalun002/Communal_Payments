using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communal_Payments
{
    public enum Season { Spring = 1, Summer = 2, Autumn = 3, Winter = 4 }
    public enum Privileges { VeteranOfLabour = 1, WarVeteran = 2 }

    /// <summary>
    /// плательщик
    /// </summary>
    public class Payer
    {
        /// <summary>
        /// метраж помещения
        /// </summary>
        public int Area { get; set; }

        /// <summary>
        /// количество проживающих людей
        /// </summary>
        public int Residents { get; set; }

        /// <summary>
        /// сезон года
        /// </summary>
        public Season season { get; private set; }

        /// <summary>
        /// льготы
        /// </summary>
        public Privileges privileges { get; private set; }

        /// <summary>
        /// Объем потраченной воды
        /// </summary>
        public double WaterReading { get; set; }

        public Payer() { }

        public Payer(int area, int residents, int season, int privileges)
        {
            Random rand = new Random();
            Area = area;
            Residents = residents;
            this.season = (Season)season;
            this.privileges = (Privileges)privileges;
            WaterReading = rand.Next(3, 12);
        }
        
        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Площадь помещения - " + Area);
            Console.WriteLine("Kоличество проживающих - " + Residents);
            Console.WriteLine("Cезон года - " + season.ToString());
            Console.WriteLine("Льготы - " + privileges.ToString());
            Console.WriteLine();
        }
    }
}
