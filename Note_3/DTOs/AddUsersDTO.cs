using System.ComponentModel.DataAnnotations;

namespace Note_3.DTOs
{
    public record class AddUsersDTO(
    [Required]
    [StringLength(128)]
    string Name
    );
}
