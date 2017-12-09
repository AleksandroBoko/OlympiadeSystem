using OlympiadSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Logic
{
    interface ICompetitionManager
    {
        List<Competition> Olympiads { get; }
        void AddCompetition(Competition competition);
        void RemoveCompetition(Competition person);
        Competition GetCompetitionByIndex(int index);
        Competition GetCompetitionById(Guid id);
        void WriteCompetition();
    }
}
