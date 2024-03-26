using System.ComponentModel.DataAnnotations;

namespace supply_chain_server.Models;

public class User
{
    [Key]
    public int User_Id { get; set; }
    
    public string Username { get; set; }
    public string Password { get; set; }
}