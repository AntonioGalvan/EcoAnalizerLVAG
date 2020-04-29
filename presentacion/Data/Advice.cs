namespace presentacion.Data
{
    public class Advice : IEntity
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Text { get; set; }
        public string Autor { get; set; }

        public User User { get; set; }
    }
}
