<div align="center">
  <h1>💫 Product API GRAPHQL 💫</h1>
  
  <p>This is a sample README for an API that allows you to perform CRUD operations (Create, Read, Update, Delete) on products. The API is built using .NET 6, Hot Chocolate ASP.NET for GraphQL, and Entity Framework Core for data access.</p>
</div>

## Getting Started

### Prerequisites

Before you begin, ensure you have met the following requirements:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or another supported database)

### Installation

1. Clone the repository:

   ```shell
   git clone https://github.com/guilhermebernava/ApiGraphQL.git
   ```

2. Navigate to the project directory:

   ```shell
   cd product-api
   ```

3. Restore the NuGet packages:

   ```shell
   dotnet restore
   ```

4. Update the `appsettings.json` file with your database connection string:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=your-server;Database=YourDatabase;User Id=YourUsername;Password=YourPassword;"
     },
     // ...
   }
   ```

5. Apply database migrations to create the database:

   ```shell
   dotnet ef database update
   ```

### Running the Application

Start the API by running:

```shell
dotnet run
```

The API will be accessible at `https://localhost:7063` (or another port if configured differently).

## Usage

### GraphQL Playground

You can explore and interact with the API using the GraphQL Playground. Open a web browser and navigate to `https://localhost:7063/graphql`. The Playground provides an interactive interface to send GraphQL queries and mutations.

### API Endpoints

Here are some sample GraphQL queries and mutations you can use with this API:

#### Query to Get Products

```graphql
query {
  products {
    id
    nome
    preco
  }
}
```

#### Mutation to Add a Product

```graphql
mutation {
  addProduct(name: "Product Name", price: 29.99) {
    id
    nome
    preco
  }
}
```

#### Mutation to Update a Product

```graphql
mutation {
  updateProduct(id: 1, name: "New Name", price: 39.99) {
    id
    nome
    preco
  }
}
```

#### Mutation to Delete a Product

```graphql
mutation {
  deleteProduct(id: 1)
}
```

</div>
