using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Models;
using ProjetoAPI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaRepository _empresaRepositorio;

        public EmpresaController(IEmpresaRepository empresaRepository)
        {
            _empresaRepositorio = empresaRepository;
        }

        [Route("api/v1/enterprises")]
        [HttpGet]
        public IEnumerable<EmpresaViewModel> GetAll()
        {
            return _empresaRepositorio.GetAll();
        }
        [Route("api/v1/enterprises")]
        [HttpGet]
        public IEnumerable<EmpresaViewModel> FindEmpresa(string enterprise_types, string name)
        {
            return _empresaRepositorio.FindEmpresa(enterprise_types,name);
        }
        [Route("api/v1/enterprises/{id}")]
        [HttpGet]
        public EmpresaViewModel GetEmpresaById(int id)
        {
            return _empresaRepositorio.GetEmpresaById(id);
        }

        /* Não implementado */


        /* Não implementado */
    }
}
