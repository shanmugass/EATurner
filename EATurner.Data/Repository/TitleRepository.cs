using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATurner.Data.Repository
{
    /// <summary>
    /// Title Repository
    /// </summary>
    public class TitleRepository : ITitleRepository
    {
        /// <summary>
        /// The unit ofwork
        /// </summary>
        UnitOfWork unitOfwork = new UnitOfWork();

        /// <summary>
        /// Gets all Titles
        /// </summary>
        /// <returns></returns>
        public IQueryable<Model.Title> GetAll()
        {
            return unitOfwork.Titles.Get();
        }

        /// <summary>
        /// Gets the by Title Id.
        /// </summary>
        /// <param name="id">The Title Id.</param>
        /// <returns></returns>
        public Model.Title GetById(int id)
        {
            return unitOfwork.Titles.FirstOrDefault(e => e.TitleId == id);
        }

        /// <summary>
        /// Gets the by title.
        /// </summary>
        /// <param name="titleToSearch">The title to search.</param>
        /// <returns></returns>
        public IQueryable<Model.Title> GetByTitle(string titleToSearch)
        {
            return unitOfwork.Titles.Where(e => e.TitleName.ToLower().Contains(titleToSearch.ToLower()));
        }
    }
}
