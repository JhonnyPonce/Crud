using Crud.Data.Context;
using Crud.Models;

namespace Crud.Repositories
{
    public class UsuariosRepository
    {
        private readonly DataContext _context;

        public UsuariosRepository(DataContext context)
        {
            _context = context;
        }

        public List<Usuario> GetAllUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetUsuario(long cpf)
        {
            return _context.Usuarios.Find(cpf);
        }

        public void InserirUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void RemoverUsarios(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
    }
}
