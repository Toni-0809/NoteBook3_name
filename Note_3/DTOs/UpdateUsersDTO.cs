using System.ComponentModel.DataAnnotations;

namespace Note_3.DTOs
{
    public record class UpdateUsersDTO(
         [Required]
    [StringLength(128)]
    string Name
    );
}