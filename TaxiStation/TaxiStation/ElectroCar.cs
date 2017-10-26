using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation
{
    public class ElectroCar : Car
    {
        public int PowerReserve {get; set;} // Запас хода
        public int RemainderPower { get; set; }  // Остаток хода

        protected ElectroCar()
        {

        }
    }
}
