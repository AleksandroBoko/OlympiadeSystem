using OlympiadSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.DataModel
{
    interface IOlympiadData
    {
        void WriteOlympiads(object o);
        List<Competition> ReadOlympiads();
    }
}
