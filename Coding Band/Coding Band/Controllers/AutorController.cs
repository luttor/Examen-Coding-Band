using Coding_Band.DAO;
using Coding_Band.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Coding_Band.Controllers
{
    public class AutorController : ApiController
    {
        private AutorModel model;

        public AutorController() {
            this.model = new AutorModel();
        }

        public List<Autor> getAutores()
        {
            return this.model.getAll();
        }

        public bool saveAutor([FromBody]string nombre_autor)
        {
            if (this.model.save(nombre_autor))
                return true;
            else
                return false;
        }
    }
}