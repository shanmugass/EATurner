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
            return Ok(_db.GetAll().Select(e => new
                {
                    e.TitleId,
                    e.TitleName,
                    e.ReleaseYear,
                    e.ProcessedDateTimeUTC
                }));
        }

        [ResponseType(typeof(Title))]
        public async Task<IHttpActionResult> GetTitle(string id)
        {
            int titleId = 0;

            if (int.TryParse(id, out titleId))
            {
                var title = _db.GetById(titleId);
                return Ok(title);
            }
            else if (!string.IsNullOrEmpty(id))
            {
                var title = _db.GetByTitle(id).Select(e => new
                {
                    e.TitleId,
                    e.TitleName,
                    e.ReleaseYear,
                    e.ProcessedDateTimeUTC
                });
                return Ok(title);
            }

            return NotFound();
        }
    }
}