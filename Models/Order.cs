using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace supply_chain_server.Models;

public class Order
{
    [Key]
    public int Order_Id { get; set; }
    public int? Customer_Id { get; set; }
    public int? Product_Id { get; set; }
    public int? Status_Id { get; set; }
    [DataType(DataType.Currency)]
    [Column(TypeName = "money")]
    public decimal Total_Cost { get; set; }
    public int Quantity { get; set; }

    // public virtual Customer Customer { get; set; }
    // public virtual Product Product { get; set; }
    // public virtual Status Status { get; set; }
}