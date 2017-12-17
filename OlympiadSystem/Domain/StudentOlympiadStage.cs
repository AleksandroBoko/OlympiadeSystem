using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Domain
{
    class StudentOlympiadStage
    {
        public Guid Id { get; private set; }
        public Guid StudentId { get; set; }
        public Guid StageId { get; set; }

        public StudentOlympiadStage()
        {
            Id = Guid.NewGuid();
        }
    }
}
