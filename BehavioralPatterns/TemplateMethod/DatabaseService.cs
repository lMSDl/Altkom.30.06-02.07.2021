using System;

namespace WPCSharp.BehavioralPatterns.TemplateMethod
{
    public class DatabaseService : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Closing DB connection.");
        }

        public void Insert(string @string)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + @string);
        }
    }
}