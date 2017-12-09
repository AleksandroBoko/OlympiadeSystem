using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympiadSystem.Domain;

namespace OlympiadSystem.Logic
{
    class CompetitionManager : ICompetitionManager
    {
        public List<Competition> Olympiads {get; private set;}    

        public CompetitionManager()
        {

        }

        public void AddCompetition(Competition competition)
        {
            Olympiads.Add(competition);    
        }

        public Competition GetCompetitionById(Guid id)
        {
            return Olympiads.Where(n => n.Id == id).First();
        }

        public Competition GetCompetitionByIndex(int index)
        {
            return Olympiads[index];
        }

        public void RemoveCompetition(Competition competition)
        {
            Olympiads.Remove(competition);
        }

        public void WriteCompetition()
        {
            
        }
    }
}
