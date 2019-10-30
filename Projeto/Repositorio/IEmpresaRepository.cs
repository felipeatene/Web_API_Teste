using ProjetoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Repositorio
{
    public interface IEmpresaRepository
    {
        IEnumerable<EmpresaViewModel> GetAll();
        EmpresaViewModel GetEmpresaById(int id);
        IEnumerable<EmpresaViewModel> FindEmpresa(string enterprise_types, string name);       
    }
}
