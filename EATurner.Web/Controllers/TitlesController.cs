using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using EATurner.Data.Model;
using EATurner.Data.Repository;
using System.Web;

namespace EATurner.Web.Controllers
{
    public class TitlesController : ApiController
    {
        private ITitleRepository _db;

        public TitlesController(ITitleRepository db)
        {
            _db = db;
        }

        // GET: api/Titles
        public async Task<IHttpActionResult> GetTitles()
        {
            return Ok(_db.GetAll().ToList());
        }

        [ResponseType(typeof(Title))]
        public async Task<IHttpActionResult> GetTitle(string id)
        {
            var title = _db.GetByTitle(id).ToList();

            return Ok(title);
        }
    }
}