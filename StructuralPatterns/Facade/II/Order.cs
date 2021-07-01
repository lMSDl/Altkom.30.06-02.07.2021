using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Facade.II
{
    public class Order
    {
        private  ICartService cartService;
        private  IProductService productService;
        private  IPaymentService paymentService;

        public Order(ICartService cartService, IProductService productService, IPaymentService paymentService)
        {
            this.cartService = cartService;
            this.productService = productService;
            this.paymentService = paymentService;
        }
        public Order()
        {

        }

        public void Buy(int cartId, IEnumerable<int> productIds)
        {
            foreach (var id in productIds)
            {
                var price = productService.GetPrice(id);
                cartService.AddProduct(cartId, id, price);
            }
            paymentService.Pay(cartId, cartService.GetPrice(cartId));
        }
    }
}
