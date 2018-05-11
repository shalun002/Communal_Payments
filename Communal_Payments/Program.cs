using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 1.	Написать программу, рассчитывающую сумму коммунальных платежей: 
/// есть базовые тарифы на отопление (на 1 м2 площади), 
/// на воду (на 1 чел), 
/// на газ (на 1 чел), 
/// на текущий ремонт (на 1 м2 площади). 
/// Задается метраж помещения, количество проживающих людей, сезон (осенью и зимой отопление дороже), наличие льгот (ветеран труда– 30 % от его части; ветеран войны- 50% от его части). 
/// Вывести таблицу со столбцами: Вид платежа, Начислено, Льготная скидка, Итого. Посчитать итоговую сумму.
/// </summary>

namespace Communal_Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = 0, residents, saeson, privileges;

            Payer pay = new Payer();

            Console.Write("Площадь помещения - ");
            int.TryParse(Console.ReadLine(), out area);

            Console.Write("Kоличество проживающих - ");
            int.TryParse(Console.ReadLine(), out residents);

            Console.Write("Cезон года (Весна = 1, Лето = 2, Осень = 3, Зима = 4) - ");
            int.TryParse(Console.ReadLine(), out saeson);

            Console.Write("Льготы (нет льгот = 0, ветеран труда = 1, ветеран войны = 2) - ");
            int.TryParse(Console.ReadLine(), out privileges);

            Console.Clear();
            Console.WriteLine();

            Payer payer = new Payer(area, residents, saeson, privileges);
            payer.PrintInfo();

            Service service = new Service();
            service.TotalPrint(service, payer);
        }
    }
}
