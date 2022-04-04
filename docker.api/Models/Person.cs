using System.ComponentModel.DataAnnotations;

namespace docker.api.Models
{
    public partial class Person
    {
        [Key]
        public int PersonID { get; set; }

        [StringLength(255)]
        public string? LastName { get; set; }

        [StringLength(255)]
        public string? FirstName { get; set; }

        [StringLength(255)]
        public string? Address { get; set; }

        [StringLength(255)]
        public string? City { get; set; }
    }
}