using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// есть базовые тарифы на отопление (на 1 м2 площади), 
/// на воду (на 1 чел), 
/// на газ (на 1 чел), 
/// на текущий ремонт (на 1 м2 площади).
/// </summary>

namespace Communal_Payments
{
    public class Tariff
    {
        public double Heating { get; set; }
        public double Water { get; set; }
        public double Gas { get; set; }
        public double Maintenance { get; set; }
        public string TypeOfPayments { get; set; }

        public Tariff()
        {
            Heating = 31.61;              // отопление
            Water = 55.56;                // вода
            Gas = 347.48;                 // газ
            Maintenance = 17.00;          // содержание
            TypeOfPayments = "Комунальные платежи";
        }  
    }      
}          

