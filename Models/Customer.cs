using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace supply_chain_server.Models;

public class Customer
{
    [Key]
    public int Customer_Id { get; set; }
    public string Customer_Name { get; set; }
    public string Customer_Phone { get; set; }
    public string Customer_Email { get; set; }
    public string Address { get; set; }

    // public virtual ICollection<Order> Orders { get; set; }
}