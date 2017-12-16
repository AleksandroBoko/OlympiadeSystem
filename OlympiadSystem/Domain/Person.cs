using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace OlympiadSystem.Domain
{
    [DataContract]
    [KnownType(typeof(Student))]
    abstract class Person
    {
        [DataMember]
        public Guid Id { get; private set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string University { get; set; }

        public Person()
        {
            Id = Guid.NewGuid();
        }

    }
}
