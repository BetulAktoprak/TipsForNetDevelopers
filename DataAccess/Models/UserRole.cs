using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models;
public sealed class UserRole
{
    public int Id { get; set; }

    [ForeignKey("Role")]
    public int RoleId { get; set; }
    public Role Role { get; set; } = default!;

    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; } = default!;
}
