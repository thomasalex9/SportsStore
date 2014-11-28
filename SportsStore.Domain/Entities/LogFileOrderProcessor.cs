using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Entities
{
    public class LogFileOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(Cart cart, ShippingDetails shippingDetails) {

            StringBuilder body = new StringBuilder();
            body.AppendLine("A new order has been submitted");
            body.AppendLine("----");
            body.AppendLine("Items:");

            foreach (var cl in cart.Lines) 
                body.AppendFormat("{0} x {1} (subtotal: {2:c})", 
                    cl.Quantity, cl.Product.Name, cl.Subtotal);


            body.AppendFormat("Total order value: {0:c}", cart.ComputeTotalValue());
            body.AppendLine("---");
            body.AppendLine("Ship to:");
            body.AppendLine(shippingDetails.Name);
            body.AppendLine(shippingDetails.Line1);
            if (shippingDetails.Line2 != null) body.AppendLine(shippingDetails.Line2);
            if (shippingDetails.Line3 != null) body.AppendLine(shippingDetails.Line3);
            body.AppendLine(shippingDetails.City);
            body.AppendLine(shippingDetails.State);
            body.AppendLine(shippingDetails.Country);
            body.AppendLine(shippingDetails.Zip);

            Logger.Info("in Pro()cessOrder()", body.ToString());
         }
    }
}
