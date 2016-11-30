using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EMod
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int BatteryType { get; set; }
        public int MaxPower { get; set; }

        public  int ManufactorerId { get; set;  }
        public Manufactorer Manufactorer { get; set; }
    }
}
