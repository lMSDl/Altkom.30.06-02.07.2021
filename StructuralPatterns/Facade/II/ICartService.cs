using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Facade.II
{
    public interface ICartService
    {
        float GetPrice(int cartId);
        void AddProduct(int cartId, int productId, float price);
    }
}
