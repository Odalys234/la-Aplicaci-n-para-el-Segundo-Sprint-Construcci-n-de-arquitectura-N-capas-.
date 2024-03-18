using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOURTRADE.SysLoginTT.EN
{
    internal class Reservas
    {
        public int ReservaID { get; set; }
        public int UserID { get; set; }
        public int GuiaID { get; set; }
        public DateTime Fecha { get; set; }
        public string EstadoReserva  { get; set; }
        public decimal Precio { get; set; }
    }
}
