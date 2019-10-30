using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Models
{
    public class UsuarioDB : DbContext 
    {
        public UsuarioDB(DbContextOptions<UsuarioDB> options) : base(options)
        {
                
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
