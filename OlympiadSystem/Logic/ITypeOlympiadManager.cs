using OlympiadSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Logic
{
    interface ITypeOlympiadManager
    {        
        void AddTypeOlympiad(TypeOlympiad typeOlympiad);
        void RemoveTypeOlympiad(TypeOlympiad typeOlympiad);
        TypeOlympiad GetTypeOlympiadById(Guid id);
        void WriteTypeOlympiads();
    }
}
