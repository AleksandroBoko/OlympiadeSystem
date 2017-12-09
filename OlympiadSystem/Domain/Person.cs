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
        public string FirstName;
        [DataMember]
        public string LastName;
        [DataMember]
        public int Age;
        [DataMember]
        public string University;

        public Person()
        {
            Id = Guid.NewGuid();
        }

    }
}
