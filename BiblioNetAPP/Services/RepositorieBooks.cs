using BiblioNetAPP.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BiblioNetAPP.Services
{
    public interface IRepositorieBooks
    {
        void Create(Books books);
    }
    public class RepositorieBooks : IRepositorieBooks
    {
        private readonly string connectionString;
        public RepositorieBooks(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public void Create(Books books)
        {
            using var connection = new SqlConnection(this.connectionString);
           var id = connection.QuerySingle<int>($@"INSERT INTO Books ([BookName], [AuthorId], Price) VALUES(@BookName, @AuthorId, @Price); SELECT SCOPE_IDENTITY();", books);

            books.Id = id;
        }
    }
}
