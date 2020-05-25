using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.COMMON.Entidades
{
    class ContraseñaCliente:Base
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string CContraseña { get; set; }
        public override string ToString()
        {
            return Usuario;
        }
    }
}
