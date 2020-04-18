using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class OrderItem
    {
        protected Product product;
        protected int qnty;

        protected double ProductPrice { get { return product.Price; } }
        protected double Qnty { get { return product.Qnty; } }

        public OrderItem(Product product, int qnty)
        {
            this.product = product;
            this.qnty = qnty;
        }
    }
}
