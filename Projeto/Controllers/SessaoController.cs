using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Models;
using ProjetoAPI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Controllers
{
    public class SessaoController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepositorio;

        public SessaoController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepositorio = usuarioRepository;
        }

        [Route("api/v1/users/auth/sign_in")]
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var usu = _usuarioRepositorio.FindByEmailSenha(email, password);

            if (usu == null)
                return NotFound();
            
            return new ObjectResult(usu);
        }
        
    }
}
