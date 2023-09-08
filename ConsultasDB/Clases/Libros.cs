using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasDB.Clases
{
    public class Libros
    {
        public int CodigoLibro { get; set; }
        public string? Titulo { get; set; }
        public int CantidadPaginas { get; set; }
        public int CodigoMateria { get; set; }
    }
}
