using LunchStore.Models;
using Microsoft.EntityFrameworkCore;

namespace LunchStore.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
            //Carrega as informações necessárias para configurar o DB
        }

        public DbSet<Categoria> Categorias { get; set; } //Define o nome das tabelas que serão criadas
        public DbSet<Lanche> Lanches { get; set; }


    }
}
