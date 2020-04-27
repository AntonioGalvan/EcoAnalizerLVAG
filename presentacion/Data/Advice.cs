namespace presentacion.Data
{
    public class Advice : IEntity
    {
        public int Id { get; set; }

        public User User { get; set; }
    }
}
