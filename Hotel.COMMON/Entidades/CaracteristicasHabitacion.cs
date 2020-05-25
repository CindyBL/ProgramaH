using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.COMMON.Entidades
{
    class CaracteristicasHabitacion:Base
    {
        public string TipoHabitacion { get; set; }
        public string NCamas { get; set; }
        public string NBaños { get; set; }
    }
}
