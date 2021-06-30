using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.Singleton
{
    public class Context
    {
        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>();

        private Context()
        {
            Console.WriteLine("Inicjalizacja ustawień");

            _settings.Add("1", "A");
            _settings.Add("2", "B");
            _settings.Add("3", "C");
        }

        public string GetSettings(string key)
        {
            return _settings[key];
        }
        public void SetSettings(string key, string value)
        {
            _settings[key] = value;
        }

        //private static Context _instance;
        //public static Context GetInstance()
        //{
        //    if (_instance == null)
        //        _instance = new Context();

        //    return _instance;
        //}

        //private static object _locker = new object();
        //public static Context GetInstance()
        //{
        //    lock (_locker)
        //    {
        //        if (_instance == null)
        //            _instance = new Context();

        //        return _instance;
        //    }
        //}

        //private readonly static Context _instance = new Context();
        //public static Context GetInstance()
        //{
        //    return _instance;
        //}
        //static Context()
        //{

        //}

        //public static readonly Lazy<Context> lazy = new Lazy<Context>(() => new Context());
        //public static Context GetInstance()
        //{
        //    return lazy.Value;
        //}
        static Context()
        {

        }

        public static Context Instance { get; } = new Context();
    }
}
