using EATurner.Data.Model;
using System;
using System.Data.Entity;

namespace EATurner.Data.Repository
{
    /// <summary>
    /// Database Access
    /// </summary>
    public class UnitOfWork : IDisposable
    {

        /// <summary>
        /// The _context of Database
        /// </summary>
        private readonly DbContext _context = new EATurnerModel();

        #region Generic repositories definition

        private GenericRepository<Title> _titlesRepository;

        #endregion

        #region Generic repository declaration


        /// <summary>
        /// Gets the titles.
        /// </summary>
        /// <value>
        /// The titles.
        /// </value>
        public GenericRepository<Title> Titles
        {
            get { return _titlesRepository ?? (_titlesRepository = new GenericRepository<Title>(_context)); }
        }




        #endregion

        #region Functionality

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }
        
        /// <summary>
        /// Disables the automatic detect changes.
        /// </summary>
        public void DisableAutoDetectChanges()
        {
            _context.Configuration.AutoDetectChangesEnabled = false;
        }

        private bool _disposed = false;

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
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

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}