using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympiadSystem.Domain;
using System.Runtime.Serialization.Json;
using System.IO;

namespace OlympiadSystem.DataModel
{
    class OlympiadData : IOlympiadData
    {
        public List<Competition> ReadOlympiads()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Competition>));

            using (FileStream fs = new FileStream("olympiads.json", FileMode.OpenOrCreate))
            {
                return fs.Length == 0 ? (List<Competition>)jsonFormatter.ReadObject(fs) : new List<Competition>(); 
            }
        }

        public void WriteOlympiads(object o)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Competition>));

            using (FileStream fs = new FileStream("olympiads.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, o);
            }
        }
    }
}
