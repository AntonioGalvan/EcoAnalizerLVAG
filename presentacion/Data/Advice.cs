namespace presentacion.Data
{

    public class Advice : IEntity
    {

        public int Id { get; set; }
        public string Texto { get; set; }
        public string Autor { get; set; }

        public User User { get; set; }
    }
}
