using EATurner.Data.Model;
using System;
using System.Data.Entity;

namespace EATurner.Data.Repository
{
    public class UnitOfWork : IDisposable
    {

        private readonly DbContext _context = new EATurnerModel();

        #region Generic repositories definition

        private GenericRepository<Title> _titlesRepository;

        #endregion

        #region Generic repository declaration


        public GenericRepository<Title> Titles
        {
            get { return _titlesRepository ?? (_titlesRepository = new GenericRepository<Title>(_context)); }
        }




        #endregion

        #region Functionality

        public void Save()
        {
            _context.SaveChanges();
        }

        //TODO: don't like this method  there, better to include in context to any operations
        public void DisableAutoDetectChanges()
        {
            _context.Configuration.AutoDetectChangesEnabled = false;
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}