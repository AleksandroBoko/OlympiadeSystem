using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Domain
{
    class Stage
    {
        public Guid Id { get; private set; }
        public Guid OlympiadId { get; set; }
        public string NameStage { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public bool IsFinal { get; set; }

        public Stage()
        {
            Id = Guid.NewGuid();
        }
    }
}
