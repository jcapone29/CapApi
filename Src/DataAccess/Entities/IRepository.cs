using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    interface IRepository 
    {

        Task<IEnumerable<Potato>> GetPotatos(string id);
        Task<IEnumerable<Potato>> CreatePotato(Potato user);
        Task<IEnumerable<Leagues>> GetLeagues(Leagues league);
        Task<IEnumerable<Leagues>> CreateLeague(Leagues league);
        Task<IEnumerable<Scores>> AddScore(Scores id);
        Task<IEnumerable<Scores>>GetScores(string id);

    }
}
