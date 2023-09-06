using Api.Data;
using Api.Entities;

namespace Api.Mutations;

public class ProductMutation
{
    public Product AddProduct(
        [Service] ApplicationDbContext context,
        string name,
        decimal price)
    {
        var produto = new Product
        {
            Nome = name,
            Preco = price
        };

        context.Products.Add(produto);
        context.SaveChanges();

        return produto;
    }

    public Product UpdateProduct(
        [Service] ApplicationDbContext context,
        int id,
        string name,
        decimal price)
    {
        var produto = context.Products.Find(id);

        if (produto == null)
        {
            throw new GraphQLException("Product não encontrado.");
        }

        produto.Nome = name;
        produto.Preco = price;

        context.SaveChanges();

        return produto;
    }

    public bool DeleteProduct(
        [Service] ApplicationDbContext context,
        int id)
    {
        var produto = context.Products.Find(id);

        if (produto == null)
        {
            throw new GraphQLException("Product não encontrado.");
        }

        context.Products.Remove(produto);
        context.SaveChanges();

        return true;
    }
}
