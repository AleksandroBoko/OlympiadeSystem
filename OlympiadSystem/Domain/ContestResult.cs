using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Domain
{
    class ContestResult
    {
        public Guid Id { get; private set; }
        public Guid StudentContestId { get; set; }
        public int Place { get; set; }
        public string Comment { get; set; }

        public ContestResult()
        {
            Id = Guid.NewGuid();
        }
    }
}
