using System.ComponentModel.DataAnnotations;

namespace supply_chain_server.Models;

public class Role
{
    [Key]
    public int Role_Id { get; set; }
    [Required]
    [MaxLength(20)]
    public string Role_Name { get; set; }
}