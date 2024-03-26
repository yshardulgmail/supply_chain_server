using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace supply_chain_server.Models;

public class Product
{
    [Key]
    public int Product_Id { get; set; }
    public string Product_Name { get; set; }
    [DataType(DataType.Currency)]
    [Column(TypeName = "money")]
    public decimal Product_Cost { get; set; }
    public int Quantity { get; set; }

    // public virtual ICollection<Order> Orders { get; set; }
}