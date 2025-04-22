using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
using Models;
using Views;

namespace SistemaDePedidos.Controllers
{
    class OrderController
    {
        private ClientController cController;
        private ProductController pController;
        public Order currentOrder {  get; set; }

        public OrderController()
        {
            this.cController = new ClientController();
            this.pController = new ProductController();
        }

        public void CreateOrder()
        {
            currentOrder = new Order();
            currentOrder.client = ClientView.LoadClient();
            currentOrder.setProductList(OrderView.LoadProductList());
        }
    }
}
