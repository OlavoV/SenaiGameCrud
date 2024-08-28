using Microsoft.EntityFrameworkCore;
using SenaiGameCrud.Models;

namespace SenaiGameCrud.Context
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options) 
        {
            
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }

    }

}
