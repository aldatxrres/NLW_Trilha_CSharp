using FluentAssertions;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;
using Xunit;

namespace UseCases.Test.Auctions.GetCurrent;
public class GetCurrentAuctionUseCaseTest
{
    [Fact]
    public void Success()
    {
        ///critério dos AAA

        ///ARRANGE (inicializar tudo que precisamos)
        var useCase = new GetCurrentAuctionUseCase(null);

        ///ACT (utilizar as instâncias que foram inicializadas)
        var auction = useCase.Execute();
        
        ///ASSERT (testar se o resultado devolvido era o esperado - nunca faça if em testes de unidade)
        //Assert.NotNull(auction); do próprio .NET

        auction.Should().NotBeNull(); //vindo do plugin FluentAssertions (mto usado nas empresas)
    }
}
