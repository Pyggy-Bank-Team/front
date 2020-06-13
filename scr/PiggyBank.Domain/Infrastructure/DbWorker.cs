using System;
using Microsoft.EntityFrameworkCore;
using PiggyBank.Model;
using PiggyBank.Model.Interfaces;

namespace PiggyBank.Domain.Infrastructure
{
    public class DbWorker : IDisposable
    {
        private readonly PiggyContext _context;

        public DbWorker(PiggyContext context)
            => _context = context;

        public DbSet<T> GetRepository<T>() where T : class, IBaseModel
            => _context.Set<T>();

        public void Dispose()
            => _context?.Dispose();
    }
}
