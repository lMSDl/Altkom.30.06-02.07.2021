using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Proxy
{
    public class DatabaseProxy : IDatabase
    {
        public const int Count = 3;

        private Database database;
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(Count);

        public DatabaseProxy(Database database)
        {
            this.database = database;
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if (database == null)
            {
                Console.WriteLine("Otwieranie połączenia do bazy przez proxy");
                database = new Database();
            }

            await semaphore.WaitAsync();
            var result = await database.RequestAsync(parameter);
            semaphore.Release();

            if (semaphore.CurrentCount == Count)
            {
                Console.WriteLine("Zamykanie połączenia do bazy przez proxy");
                database = null;
            }

            return result;
        }
    }
}
