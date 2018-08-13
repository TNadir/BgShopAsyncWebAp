using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BgShop.Data.Services.Game;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BgShop.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [EnableCors("AllowAnyOrigin")]
    public class GameController : Controller
    {
        private readonly IGameService _GameService;
        public GameController(IGameService _gameService) => this._GameService = _gameService;
        
        [HttpGet]
        [ActionName("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await this._GameService.GetAllGames());
        }


    }
}