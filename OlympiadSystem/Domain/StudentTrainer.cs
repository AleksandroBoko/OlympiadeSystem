using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Domain
{
    class StudentTrainer
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid TrainerId { get; set; }

        public StudentTrainer()
        {
            Id = Guid.NewGuid();
        }
    }
}
