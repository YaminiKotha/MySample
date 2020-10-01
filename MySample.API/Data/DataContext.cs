using Microsoft.EntityFrameworkCore;
using MySample.API.Models;

namespace MySample.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}    
        public DbSet<Value> Values { get; set; }   
        
    }
}