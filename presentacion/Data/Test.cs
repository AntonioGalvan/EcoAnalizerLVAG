using System.Collections.Generic;

namespace presentacion.Data
{
    public class Test : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public Expert Expert { get; set; }
        public ICollection<TestQuestion> TestQuestions { get; set; }
    }
}