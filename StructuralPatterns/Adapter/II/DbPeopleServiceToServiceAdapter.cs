using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Adapter.II
{
    class DbPeopleServiceToServiceAdapter : IPeopleService
    {
        private DbPeopleService _service;

        public DbPeopleServiceToServiceAdapter(DbPeopleService service)
        {
            _service = service;
        }

        public Task<IEnumerable<IPerson>> GetAsync()
        {
            var dbPeople = _service.Get();
            var people = dbPeople.Select(x => new DbPersonToPersonAdapter(x)).Cast<IPerson>().AsEnumerable();
            return Task.FromResult(people);
        }
    }
}
