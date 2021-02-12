using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioQuiz.Model
{
    public class Entity
    {
        public Entity()
        {
            Guid = new Guid();
        }
        public int Id { get; set; }
        public Guid Guid { get; set; }
    }
}
