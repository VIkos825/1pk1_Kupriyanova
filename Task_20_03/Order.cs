using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    internal class Order
    {
        public OrderStatus Status { get; set; }
        public Order() { Status = OrderStatus.New; }
        public void ChangeStatus()
        {
            if (Status != OrderStatus.Cancelled && Status != OrderStatus.Delivered)
            {
                Status++;
                Console.WriteLine("Статус заказа изменен с {0} на {1}", Status-1, Status);
            }
            else Console.WriteLine("Заказ уже доставлен или отменен!");
        }

        public void CancelOrder()
        {
            if (Status != OrderStatus.Cancelled && Status != OrderStatus.Delivered) 
            {
                Status = OrderStatus.Cancelled;
                Console.WriteLine("Заказ отменен");
            }
            else Console.WriteLine("Заказ уже доставлен или отменен!");
        }
    }
}
