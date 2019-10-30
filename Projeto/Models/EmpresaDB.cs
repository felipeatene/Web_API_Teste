using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Models
{
    public class EmpresaDB : DbContext
    {
        public EmpresaDB(DbContextOptions<EmpresaDB> options) : base(options){ }
        public DbSet<Empresa> Empresas { get; set; }
    }
}
