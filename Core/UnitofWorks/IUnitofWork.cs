using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitofWorks
{
    public interface IUnitofWork
    {
        Task CommitAsync(); //SaveChancesAsync()
        void Commit(); //SaveChances();
    }
}
