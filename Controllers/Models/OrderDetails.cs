using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoPowerLogistics_Project2_API.Controllers.Models
{
    public class OrderDetails
    {
        public Guid OrderDetailsID { get; set; }
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
    }
}
