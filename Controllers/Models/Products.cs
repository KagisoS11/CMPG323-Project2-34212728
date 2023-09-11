using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoPowerLogistics_Project2_API.Controllers.Models
{
    public class Products
    {
        [Key] public int ProductsID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescrpition { get; set; }

    }
}
