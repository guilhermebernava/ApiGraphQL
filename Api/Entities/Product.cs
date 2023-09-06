using HotChocolate;
using HotChocolate.Types;

namespace Api.Entities;
public class Product
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}


