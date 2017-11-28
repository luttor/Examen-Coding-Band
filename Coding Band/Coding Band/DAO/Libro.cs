using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coding_Band.DAO
{
    public class Libro
    {
        public int id_libro { set; get; }
        public string titulo { set; get; }
        public DateTime fecha_edicion { set; get; }

        public string autores { set; get; }
        public int cantidadAutores { set; get; }
    }
}