
using DockerAspnetMysqlDio.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
namespace DockerAspnetMysqlDio.Data
{
    public class BookContextDB : DbContext
    {
        public BookContextDB(DbContextOptions<BookContextDB> options) : base(options) { }
       
        public DbSet<Books> Books { get; set; }


    }
}
