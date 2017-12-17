using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace OlympiadSystem.Domain
{
    [DataContract]
    class TypeOlympiad
    {
        [DataMember]
        public Guid Id { get; private set; }
        [DataMember]
        public string Name { get; set; }

        public TypeOlympiad()
        {
            Id = Guid.NewGuid();
        }
    }
}
