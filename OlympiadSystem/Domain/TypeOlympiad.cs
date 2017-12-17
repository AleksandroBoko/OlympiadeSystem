using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Domain
{
    class TypeOlympiad
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public TypeOlympiad()
        {
            Id = Guid.NewGuid();
        }
    }
}
