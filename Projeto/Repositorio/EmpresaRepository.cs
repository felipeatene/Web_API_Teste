using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAPI.Models;

namespace ProjetoAPI.Repositorio
{
    public class EmpresaRepository : IEmpresaRepository
    {
        public EmpresaDB _contexto;

        public EmpresaRepository(EmpresaDB ctx)
        {
            _contexto = ctx;
        }

        public IEnumerable<EmpresaViewModel> FindEmpresa(string enterprise_types, string name)
        {
            return (from e in _contexto.Empresas
                    where e.Tipo == enterprise_types || e.Nome.Contains(name)
                    select new EmpresaViewModel
                    {
                        Endereco = e.Endereco,
                        Nome = e.Nome,
                        Tipo = e.Tipo
                    }).ToList();
        }

        public IEnumerable<EmpresaViewModel> GetAll()
        {
            return (from e in _contexto.Empresas
                    select new EmpresaViewModel
                    {
                        Endereco = e.Endereco,
                        Nome = e.Nome,
                        Tipo = e.Tipo
                    }).ToList(); 
        }

        public EmpresaViewModel GetEmpresaById(int id)
        {
            return (from e in _contexto.Empresas
                    where e.Id == id
                    select new EmpresaViewModel
                    {
                        Endereco = e.Endereco,
                        Nome = e.Nome,
                        Tipo = e.Tipo
                    }).FirstOrDefault();
        }
    }
}
