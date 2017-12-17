using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Domain
{
    class Contest:Competition
    {
        public DateTime Date { get; set; }
        public int CountWinnerPlace { get; set; }
    }
}
