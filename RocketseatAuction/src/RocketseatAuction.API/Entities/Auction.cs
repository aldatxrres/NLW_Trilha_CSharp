namespace RocketseatAuction.API.Entities;

public class Auction
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; 
    //ao invés de null, retorna uma string vazia se eu não passar nenhum nome, isso evita lançamentos de exceção

    public DateTime Starts { get; set; }
    public DateTime Ends { get; set; } 
    public List<Item> Items { get; set; } = [];
    //get eu permito recuperar o valor da classe, set eu permito alterar o valor dela
}
