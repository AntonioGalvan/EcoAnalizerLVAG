namespace presentacion.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Advice : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Texto { get; set; }
        [Required]
        [StringLength(50)]
        public string Autor { get; set; }


        public User User { get; set; }
    }
}