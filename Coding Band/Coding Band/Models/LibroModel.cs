using Coding_Band.DAO;
using Coding_Band.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coding_Band.Models
{
    public class LibroModel : UtilsConnection
    {
        private Libro libro;

        public LibroModel()
        {
            this.libro = new Libro();
        }

        public List<Libro> getAll()
        {
            return Query<Libro>("select * from libro");
        }

        public bool save(Libro l)
        {
            bool status = false;

            string sql = @"
                    insert into libro values(@titulo, @fecha_edicion);
                    SELECT CAST(SCOPE_IDENTITY() as int)";

            var id_libro = Query<int>(sql, new { l.titulo, l.fecha_edicion }).Single();

            //int count = Execute("insert into libro values(@titulo, @fecha_edicion)", new { l.titulo, l.fecha_edicion });
            if (id_libro > 0)
            {
                var autores = JsonConvert.DeserializeObject<Dictionary<string, string>>(l.autores);

                foreach (var obj in autores)
                {
                    if (obj.Value == "True")
                    {
                        int id_autor = Convert.ToInt32(obj.Key);
                        try
                        {
                            Execute("insert into autor_libro values(@id_autor, @id_libro)", new { id_autor, id_libro });
                        }
                        catch (Exception e)
                        {

                        }
                    }
                }
            }

            return status;
        }
    }
}