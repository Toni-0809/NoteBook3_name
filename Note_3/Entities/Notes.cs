
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Note_3.Entities
{
    public class Notes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Entry { get; set; }

        public int UsersId { get; set; }
        public Users? Users { get; set; }

    } 
}