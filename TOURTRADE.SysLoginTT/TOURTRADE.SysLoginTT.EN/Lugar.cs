using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOURTRADE.SysLoginTT.EN
{
    internal class Lugar
    {
        public int LugarID { get; set; }
        public string NombreLugar { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaID { get; set; }
        public string Ubicacion { get; set; }
        public List<string> Fotos { get; set; }
    }
}
