using System.ComponentModel.DataAnnotations;
using Domain.Entities.Association;

namespace Domain.Entities.Membership;

// Derived entity from User.cs
public class Customer : User
{
    [StringLength(127)] public string FirstName { get; set; } = null!;

    [StringLength(127)] public string LastName { get; set; } = null!;

    [StringLength(1023)]
    public string Avatar { get; set; } = "https://static.zooniverse.org/www.zooniverse.org/assets/simple-avatar.png";

    public virtual ICollection<CustomerStoreProduct> ShoppingList { get; set; } = new List<CustomerStoreProduct>();
}