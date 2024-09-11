using System.ComponentModel.DataAnnotations;

namespace Note_3.DTOs
{
    public record class UpdateNotesDTO(

       [Required]
      [StringLength(256)]
      string Title,
       [Required] int UsersId,
       string Entry

    );
}