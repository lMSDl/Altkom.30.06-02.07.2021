using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Adapter.II
{
    public interface IPeopleService
    {
        Task<IEnumerable<IPerson>> GetAsync();
    }
}
