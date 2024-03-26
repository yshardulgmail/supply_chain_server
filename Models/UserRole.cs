using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace supply_chain_server.Models;

public class UserRole
{
    [Key]
    public int User_Id { get; set; }
    
    public int Role_Id { get; set; }


}