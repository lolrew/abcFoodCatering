using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ABC_FoodCatering.Models
{
    public class Order
    {
        public int orderID { get; set; }
        [Required]
        // Hello
        public string foodDes { get; set; }
        public string deliveryAddress { get; set; }
        public string deliveryDateAndTime { get; set; }
        public int quantity { get; set; }
        public string clientName { get; set; }
        public string orderDate { get; set; }
    }
}
