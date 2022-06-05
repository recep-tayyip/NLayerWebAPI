using Core.UnitofWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly NLayerDbContext _context;

        public UnitofWork(NLayerDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges(); 
        }

        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
