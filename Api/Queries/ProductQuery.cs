using Api.Data;
using Api.Entities;

namespace Api.Queries;
public class ProductQuery
{
    public IQueryable<Product> GetProducts([Service] ApplicationDbContext context)
    {
        return context.Products;
    }

    public IQueryable<Product> GetProductByName([Service] ApplicationDbContext context, string name)
    {
        return context.Products.Where(_ => _.Nome.Contains(name));
    }
}

