using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace DataAccess
{
    public class PotatoService : IRepository
    {
        private readonly PotatoRepository _potatoRepo;

        public PotatoService()
        {
            _potatoRepo = new PotatoRepository();
        }

        public async Task<IEnumerable<Potato>> GetPotatos(string id)
        {
            return await _potatoRepo.GetPotatos(id);

        }

        public async Task<IEnumerable<Potato>> CreatePotato(Potato potato)
        {
            return await _potatoRepo.CreatePotato(potato);
        }

        public async Task<IEnumerable<Leagues>> GetLeagues(Leagues league)
        {
            return await _potatoRepo.GetLeagues(league);
        }

        public async Task<IEnumerable<Leagues>> CreateLeague(Leagues league)
        {
            return await _potatoRepo.CreateLeague(league);
        }

        public async Task<IEnumerable<Scores>> AddScore(Scores id)
        {
            return await _potatoRepo.AddScore(id);
        }

        public async Task<IEnumerable<Scores>> GetScores(string id)
        {
            return await _potatoRepo.GetScores(id);
        }

        public async Task<IEnumerable<Potato>> GetPotato(Potato user)
        {
            return await _potatoRepo.GetPotato(user);
        }
    }
}
