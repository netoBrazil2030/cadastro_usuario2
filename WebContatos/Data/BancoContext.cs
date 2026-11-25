using Microsoft.EntityFrameworkCore;
using WebContatos.Models;

namespace WebContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }


        //tabela do banco TBContatos no sql
        public DbSet<ContatoModel> TBContatos { get; set; }
        }
    }

