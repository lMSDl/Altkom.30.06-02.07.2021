﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Facade.II
{
    public interface IPaymentService
    {
        void Pay(int cartId, float amount);
    }
}