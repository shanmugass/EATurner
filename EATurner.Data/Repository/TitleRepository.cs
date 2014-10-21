using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATurner.Data.Repository
{
    public class TitleRepository : ITitleRepository
    {
        UnitOfWork unitOfwork = new UnitOfWork();

        public IQueryable<Model.Title> GetAll()
        {
            return unitOfwork.Titles.Get();
        }

        public Model.Title GetById(int id)
        {
            return unitOfwork.Titles.FirstOrDefault(e => e.TitleId == id);
        }

        public IQueryable<Model.Title> GetByTitle(string titleToSearch)
        {
            return unitOfwork.Titles.Where(e => e.TitleName.ToLower().Contains(titleToSearch.ToLower()));
        }
    }
}
