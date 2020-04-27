using System.Collections.Generic;

namespace presentacion.Data
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Client Clients { get; set; }
        public ICollection<Advice> Advices { get; set; }
        public Expert Expert { get; set; }
    }
}
