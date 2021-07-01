using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Command
{
    public class Garden
    {
        public int Size { get; }
        private List<string> Plants { get; } = new List<string>();

        public Garden(int size)
        {
            Size = size;
        }

        public bool Plant(string name)
        {
            if(Plants.Count < Size)
            {
                Plants.Add(name);
                Console.WriteLine($"Roślina {name} została zasadzona");
                return true;
            }
            Console.WriteLine("Brak miejsca w ogrodzie");
            return false;
        }

        public bool Remove(string name)
        {
            if (Plants.Any(x => x == name))
            {
                Plants.Remove(name);
                Console.WriteLine($"Roślina {name} została usunięta");
                return true;
            }
            Console.WriteLine($"W ogrodzie nie ma {name}");
            return false;
        }

        public override string ToString()
        {
            Console.WriteLine();
            var result = string.Join("\n", Plants);
            return result + $"\nW ogrodzie jest {Plants.Count} roślin";

        }
    }
}
