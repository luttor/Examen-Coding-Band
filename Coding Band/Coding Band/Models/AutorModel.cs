using Coding_Band.DAO;
using Coding_Band.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coding_Band.Models
{
    public class AutorModel : UtilsConnection
    {
        private Autor autor;

        public AutorModel()
        {
            this.autor = new Autor();
        }

        public List<Autor> getAll()
        {
            return Query<Autor>("select * from autor");
        }

        public bool save(string nombre_autor)
        {
            return Execute("insert into autor values(@nombre_autor)", new { nombre_autor }) > 0 ? true : false;
        }

    }
}