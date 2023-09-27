using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.ClasesData
{
    public class UsuarioData
    {
        private static readonly ApplicationDbContext _context;

        public static DbSet<Usuario> GetUsuarios()
        {
            ApplicationDbContext context = _context;
            return _context.usuarios;
        }

        public static void AgregarUsuario(Usuario usuarioNuevo)
        {
            _context.usuarios.Add (usuarioNuevo);
            _context.SaveChanges ();
        }

        public static void EliminarUsuario(int id)
        {
            var UsuarioEncontrado = _context.usuarios.Find (id);
            if (UsuarioEncontrado != null)
            {
                _context.usuarios.Remove (UsuarioEncontrado);
                _context.SaveChanges ();
            }
        }

        public static void ModificarUsuario(Usuario UsuarioModificado)
        {
            var UsuarioEncontrado = _context.usuarios.Find(UsuarioModificado.id);
            if (UsuarioEncontrado != null)
            {
                UsuarioEncontrado.Contraseña = UsuarioModificado.id.ToString ();
                _context.SaveChanges ();
            }
        }
    }
}
