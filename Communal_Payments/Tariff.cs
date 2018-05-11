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

        public Tariff()
        {
            double HeatingBasicTariff = 31.61;              // отопление
            double WaterBasicTariff = 55.56;                // вода
            double GasBasicTariff = 347.48;                 // газ
            double MaintenanceBasicTariff = 17.00;          // содержание
        }  
    }      
}          

