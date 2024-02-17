using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Constants;

namespace Domain.Entities.Membership;

[Table("Customers", Schema = "Membership")]
public class Customer : User
{
    [StringLength(127)] public string FirstName { get; set; } = default!;

    [StringLength(127)] public string LastName { get; set; } = default!;

    [StringLength(15)] public new string Role { get; set; } = UserRoles.Customer;
}