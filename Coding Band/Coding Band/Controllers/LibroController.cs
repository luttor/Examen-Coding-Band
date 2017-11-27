using Coding_Band.DAO;
using Coding_Band.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Coding_Band.Controllers
{
    public class LibroController : ApiController
    {
        private LibroModel model;

        public LibroController()
        {
            this.model = new LibroModel();
        }

        public List<Libro> getLibros()
        {
            return this.model.getAll();
        }

        public bool saveLibro([FromBody]Libro l)
        {
            if (this.model.save(l))
                return true;
            else
                return false;
        }
    }
}
