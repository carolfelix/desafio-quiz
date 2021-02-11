using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioQuiz.Model
{
    public class Entity
    {
        public Entity()
        {
            Code = new Guid();
        }
        public int Id { get; set; }
        public Guid Code { get; set; }
    }
}
