using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.API.Controllers;

public class AuctionController : RocketseatBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)] //serve para documentar melhor no Swagger
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
    {
        
        var result = useCase.Execute();

         if (result is null)
            return NoContent();

        return Ok(result); 
    }

    //tudo que for funcionalidades(endpoints) em relação a leilão, coloco aqui
    //IActionResult retorna um status code/resposta 
    //se eu tenho mais de um endpoint do mesmo tipo, preciso diferenciar eles com um nome específico, ex.: [HttpGet("teste")]
}
