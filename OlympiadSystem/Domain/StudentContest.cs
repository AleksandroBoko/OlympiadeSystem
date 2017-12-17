using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Domain
{
    class StudentContest
    {
        public Guid Id { get; private set; }
        public Guid StudentId { get; set; }
        public Guid ContestId { get; set; }

        public StudentContest()
        {
            Id = Guid.NewGuid();
        }
    }
}
