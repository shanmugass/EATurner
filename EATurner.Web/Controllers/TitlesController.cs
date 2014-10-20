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
        private UnitOfWork db = new UnitOfWork();

        // GET: api/Titles
        public IQueryable<Title> GetTitles()
        {
            return db.Titles.Where(e => e.TitleName != string.Empty);
        }

        // GET: api/Titles/5
        [ResponseType(typeof(Title))]
        public async Task<IHttpActionResult> GetTitle(int id)
        {
            var title = db.Titles.GetById(id);
            if (title == null)
            {
                return NotFound();
            }
          
            return Ok(title);
        }
    }
}