using ManitoDeGato.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManitoDeGato.Repositorios
{
    public class RepositorioUsuarios
    {
        private List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario { nombreUsuario = "admin", contrasena = "1234", rol = "Admin"},
            new Usuario { nombreUsuario = "user", contrasena = "1234", rol = "Usuario"}
        };

        public Usuario Validar(string nombreUsuario, string contrasena)
        {
            nombreUsuario = nombreUsuario.Trim();
            contrasena = contrasena.Trim();

            return usuarios.FirstOrDefault(u =>
                string.Equals(u.nombreUsuario.Trim(), nombreUsuario, System.StringComparison.OrdinalIgnoreCase)
                && u.contrasena.Trim() == contrasena);
        }


    }

    }
