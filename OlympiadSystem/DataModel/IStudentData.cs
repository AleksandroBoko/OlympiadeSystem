using OlympiadSystem.Domain;
using System.Collections.Generic;

namespace OlympiadSystem.DataModel
{
    internal interface IStudentData
    {
        void WriteStudents(object o);
        List<Person> ReadStudents();
    }
}