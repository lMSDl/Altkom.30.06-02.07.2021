﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturalPatterns.Presenter
{
    public interface IView
    {
        void Load(string value);
        void Display(string value);
    }
}
