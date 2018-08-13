using System.Collections.Generic;
using System.Threading.Tasks;
using BgShop.Data.Repository;
using BgShop.Domen.Entities;

namespace BgShop.Data.Services.Game
{
    public class GameService : IGameService
    {
        private readonly IRepository<Games> _Repo;

        public GameService(IRepository<Games> _repo)
        {
            _Repo = _repo;
        }
        public  Task<IEnumerable<Games>> GetAllGames()
        {
            return  this._Repo.GetAll();
        }
    }
}