using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoPowerLogistics_Project2_API.Controllers.Models
{
    public class Customers
    {
        [Key] public int CustomerID { get; set; }
        public string CustomerTitle { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Cellphone { get; set; }
    } 
}
