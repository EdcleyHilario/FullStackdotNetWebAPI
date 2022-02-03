using Microsoft.EntityFrameworkCore;
using Proeventos.API.Models;

namespace Proeventos.API
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Evento> Eventos { get; set; }
    }
}