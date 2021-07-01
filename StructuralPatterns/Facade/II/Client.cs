using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Facade.II
{
    public class Client
    {
        //private static ICartService cartService;
        //private static IProductService productService;
        //private static IPaymentService paymentService;

        public static void Execute()
        {
            var cartId = 8212;
            var ids = new int[] { 12, 25, 54, 123 };

            //foreach (var id in ids)
            //{
            //    var price = productService.GetPrice(id);
            //    cartService.AddProduct(cartId, id, price);
            //}
            //paymentService.Pay(cartId, cartService.GetPrice(cartId));


            var order = new Order(/*TODO przekazanie instancji serwisów*/);
            order.Buy(cartId, ids);
        }
    }
}
