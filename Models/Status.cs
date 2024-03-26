using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace supply_chain_server.Models;

public class Status
{
    [Key]
    public int Status_Id { get; set; }
    public string Status_Name { get; set; }
    // public virtual ICollection<Order> Orders { get; set; }
}