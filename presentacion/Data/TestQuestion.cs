﻿
using System.Collections.Generic;

namespace presentacion.Data
{
    public class TestQuestion : IEntity
    {
        public int Id { get; set; }

        public Test Test { get; set; }
        public Question Question { get; set; }
        public ICollection<Response> Responses { get; set; }
    }
}