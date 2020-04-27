using presentacion.Data;
using System.Data.Entity;

namespace presentacion
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name = EcoAnalizer")
        {

        }

        DbSet<Advice> Advices { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<Expert> Experts { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<Response> Responses { get; set; }
        DbSet<Test> Tests { get; set; }
        DbSet<TestQuestion> TestQuestions { get; set; }
        DbSet<User> Users { get; set; }
    }
}

