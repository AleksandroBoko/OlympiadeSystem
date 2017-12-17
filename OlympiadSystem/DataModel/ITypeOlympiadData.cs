using OlympiadSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.DataModel
{
    interface ITypeOlympiadData
    {
        void WriteTypeOlympiads(object o);
        List<TypeOlympiad> ReadTypeOlympiads();
    }
}
