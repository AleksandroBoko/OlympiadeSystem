using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympiadSystem.Domain;
using OlympiadSystem.DataModel;

namespace OlympiadSystem.Logic
{
    class StudentManager : IStudentManager
    {
        public List<Person> Students {get; private set;}
        IStudentData StudentData;

        public StudentManager()
        {
            StudentData = new StudentData();
            Students = StudentData.ReadStudents();
             
        }

        public void AddStudent(Person person)
        {
            Students.Add(person);
        }

        public Person GetStudeentByIndex(int index)
        {
            return Students[index];
        }

        public Person GetStudentById(Guid id)
        {
            return Students.Where(n => n.Id == id).First();
        }

        public void RemoveStudent(Person person)
        {
            Students.Remove(person);
        }

        public void WriteStudents()
        {
            StudentData.WriteStudents(Students);          
        }
    }
}
