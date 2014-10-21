using EATurner.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATurner.Data.Repository
{
    /// <summary>
    /// Title Reposoty Interface
    /// </summary>
    public interface ITitleRepository
    {
        /// <summary>
        /// Gets all Titles
        /// </summary>
        /// <returns></returns>
        IQueryable<Title> GetAll();

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Title GetById(int id);

        /// <summary>
        /// Gets the by title.
        /// </summary>
        /// <param name="titleToSearch">The title to search.</param>
        /// <returns></returns>
        IQueryable<Title> GetByTitle(string titleToSearch);
    }
}
