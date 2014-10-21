using EATurner.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATurner.Data.Repository
{
    public interface ITitleRepository
    {
        IQueryable<Title> GetAll();

        Title GetById(int id);

        IQueryable<Title> GetByTitle(string titleToSearch);
    }
}
