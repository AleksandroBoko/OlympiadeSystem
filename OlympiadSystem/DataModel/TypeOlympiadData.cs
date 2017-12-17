using OlympiadSystem.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.DataModel
{
    class TypeOlympiadData : ITypeOlympiadData
    {
        public List<TypeOlympiad> ReadTypeOlympiads()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<TypeOlympiad>));

            using (FileStream fs = new FileStream("typeolympiads.json", FileMode.OpenOrCreate))
            {
                return fs.Length != 0 ? (List<TypeOlympiad>)jsonFormatter.ReadObject(fs) : new List<TypeOlympiad>();
            }
        }

        public void WriteTypeOlympiads(object o)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<TypeOlympiad>));

            using (FileStream fs = new FileStream("typeolympiads.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, o);
            }
        }
    }
}
