using ProjetoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Repositorio
{
    public interface IUsuarioRepository
    {
        UsuarioViewModel FindByEmailSenha(string email, string senha);
    }
}
