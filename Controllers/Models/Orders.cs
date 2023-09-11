using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoPowerLogistics_Project2_API.Controllers.Models
{
    public class Orders
    {
        [Key] public int OrderID { get; set; }
        public string OrderDate { get; set; }

        public int CustomerID { get; set; }
        public string DeliveryAddress { get; set; }

    }
}
