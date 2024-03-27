using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace supply_chain_server.Models;

public class Customer
{
    [Key]
    public int CId { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    // public virtual ICollection<Order> Orders { get; set; }
}