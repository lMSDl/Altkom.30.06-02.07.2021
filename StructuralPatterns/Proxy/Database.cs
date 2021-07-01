﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Proxy
{
    public class Database : IDatabase
    {
        private int _connectionCounter = 0;
        public async Task<int?> RequestAsync(int parameter)
        {
            if (_connectionCounter >= 5)
            {
                Console.WriteLine($"Request {parameter} dropped!");
                return null;
            }

            _connectionCounter++;
            Console.WriteLine($"Opening connectino {_connectionCounter}");
            await Task.Delay(1000);

            Console.WriteLine($"Request {parameter} completed ({_connectionCounter})");
            _connectionCounter--;
            return parameter;
        }
    }
}
