using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Domain
{
    abstract class Competition
    {
        public Guid Id;
        public string Name;
        public string City;
        public string Place;
        public string Subject;
        public bool IsActive;

        public Competition()
        {
            Id = Guid.NewGuid();
        }
    }
}
