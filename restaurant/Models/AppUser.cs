using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace restaurant.Models;

public class AppUser : IdentityUser
{
    public string Name { get; set; }
    public string Surname { get; set; }

    [NotMapped]
    public string FullName { get => $"{Name} {Surname}"; }

}
