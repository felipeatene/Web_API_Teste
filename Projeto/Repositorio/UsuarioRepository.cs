using ProjetoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioDB _contexto;

        public UsuarioRepository(UsuarioDB ctx)
        {
            _contexto = ctx;
        }

        public UsuarioViewModel FindByEmailSenha(string email, string senha)
        {
            return ( from usu in _contexto.Usuarios
                     where (usu.Email == email && usu.Senha == senha)
                     select new UsuarioViewModel
                     {
                         Email = usu.Email,
                         Id = usu.Id,
                         Nome = usu.Nome,
                         Token = "token" /* Não implementado */
                     }).FirstOrDefault();
        }
    }
}
