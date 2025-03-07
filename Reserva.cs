using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vuelos
{
    
        public class Reserva
        {
            public string CodigoVuelo { get; set; }
            public string Origen { get; set; }
            public string Destino { get; set; }
            public DateTime FechaSalida { get; set; }
            public int AsientosReservados { get; set; }
        }
    
}
