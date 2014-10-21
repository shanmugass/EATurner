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
    /// <summary>
    /// Titles Web API Controller
    /// </summary>
    public class TitlesController : ApiController
    {
        private ITitleRepository _db;

        /// <summary>
        /// Initializes a new instance of the <see cref="TitlesController"/> class.
        /// </summary>
        /// <param name="db">The database.</param>
        public TitlesController(ITitleRepository db)
        {
            _db = db;
        }

        // GET: api/Titles
        /// <summary>
        /// Gets the titles.
        /// </summary>
        /// <returns>Return Title</returns>
        public IHttpActionResult GetTitles()
        {
            return Ok(_db.GetAll().Select(e => new
                {
                    e.TitleId,
                    e.TitleName,
                    e.ReleaseYear,
                    e.ProcessedDateTimeUTC
                }));
        }

        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <param name="id">Gets the Title by Given Id.</param>
        /// <param name="isTextSearch">Set true if it is text search otherwise false.</param>
        /// <returns></returns>
        [ResponseType(typeof(Title))]
        public IHttpActionResult GetTitle(string id, bool isTextSearch)
        {
            int titleId = 0;

            if (!string.IsNullOrEmpty(id) && isTextSearch)
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
            else if (int.TryParse(id, out titleId))
            {
                var title = _db.GetById(titleId);
                return Ok(title);
            }

            return NotFound();
        }
    }
}