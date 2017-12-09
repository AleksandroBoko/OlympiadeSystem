using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using OlympiadSystem.Domain;
using System.IO;

namespace OlympiadSystem.DataModel
{
    class StudentData : IStudentData
    {
        public void WriteStudents(object o)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Person>));

            using (FileStream fs = new FileStream("student.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, o);
            }
        }

        public List<Person> ReadStudents()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Person>));

            using (FileStream fs = new FileStream("student.json", FileMode.OpenOrCreate))
            {

                return fs.Length != 0 ? (List<Person>)jsonFormatter.ReadObject(fs) : new List<Person>();
            }
        }

    }
}
