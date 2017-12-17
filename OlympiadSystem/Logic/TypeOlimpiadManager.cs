using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympiadSystem.Domain;
using OlympiadSystem.DataModel;

namespace OlympiadSystem.Logic
{
    class TypeOlimpiadManager : ITypeOlympiadManager
    {
        public TypeOlimpiadManager()
        {
            typeOlympiadData = new TypeOlympiadData();
            typeOlympiads = typeOlympiadData.ReadTypeOlympiads();            
        }

        private readonly List<TypeOlympiad> typeOlympiads;
        private readonly ITypeOlympiadData typeOlympiadData;

        public void AddTypeOlympiad(TypeOlympiad typeOlympiad)
        {
            typeOlympiads.Add(typeOlympiad);
        }

        public TypeOlympiad GetTypeOlympiadById(Guid id)
        {
            return typeOlympiads.FirstOrDefault(x => x.Id == id);
        }

        public void RemoveTypeOlympiad(TypeOlympiad typeOlympiad)
        {
            typeOlympiads.Remove(typeOlympiad);
        }

        public void WriteTypeOlympiads()
        {
            typeOlympiadData.WriteTypeOlympiads(typeOlympiads);
        }
    }
}
