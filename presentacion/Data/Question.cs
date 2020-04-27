using System.Collections.Generic;

namespace presentacion.Data
{
    public class Question : IEntity
    {
        public int Id { get; set; }

        public ICollection<TestQuestion> TestQuestions { get; set; }
    }
}

