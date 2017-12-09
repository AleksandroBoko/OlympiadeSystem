using OlympiadSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Logic
{
    interface IStudentManager
    {
        List<Person> Students { get; }
        void AddStudent(Person person);
        void RemoveStudent(Person person);
        Person GetStudeentByIndex(int index);
        Person GetStudentById(Guid id);
        void WriteStudents();       
    }
}
