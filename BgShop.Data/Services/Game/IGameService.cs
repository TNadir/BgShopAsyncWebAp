using System.Collections.Generic;
using System.Threading.Tasks;
using BgShop.Domen.Entities;

namespace BgShop.Data.Services.Game
{
    public interface IGameService
    {
        Task<IEnumerable<Games>> GetAllGames();

    }
}