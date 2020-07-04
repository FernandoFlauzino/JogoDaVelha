using CaseItauJogoDaVelha.Application.Helper;
using CaseItauJogoDaVelha.Application.Interface;
using CaseItauJogoDaVelha.Application.Request;
using CaseItauJogoDaVelha.Application.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CaseItauJogoDaVelha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;

        public GameController(ILogger<GameController> logger)
        {
            _logger = logger;
        }

      
        [HttpPost()]
        [Produces(typeof(ResultResponse))]
        public async Task<ResultResponse> Post(
          [FromBody] GameRequest request
          ,[FromServices] IGameService service)
        {
            try
            {
                if (request.IsValid())
                {
                    var result = await service.HasWinner(request.Matrix);
                    return ResultResponse.CreateSuccess(result);
                }

                return ResultResponse.CreateError(Constants.errorMessageInvalidMatrix);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString(), "GameController.Post");

                throw ex;
            }

        }
    }
}