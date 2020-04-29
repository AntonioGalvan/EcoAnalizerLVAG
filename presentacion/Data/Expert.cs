using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace presentacion.Data
{
    public class Expert : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(4)]
        public int Age { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        [Required]
        [StringLength(30)]
        public string Degree { get; set; }
        [StringLength(100)]
        public string ImageUrl { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Test> Tests { get; set; }
    }
}