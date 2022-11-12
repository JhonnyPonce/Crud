using Crud.Data.Context;
using Crud.Models;
using Crud.Repositories;

namespace Crud.Services
{
    public class UsuariosService
    {
        private readonly UsuariosRepository _repository;

        public UsuariosService (UsuariosRepository repository)
        {
            _repository = repository;
        }
        public List<Usuario> GetAllUsuarios()
        {
            return _repository.GetAllUsuarios();
        }

        public Usuario GetUsuario(long cpf)
        {
            return _repository.GetUsuario(cpf);
        }

        public void InserirUsuario(Usuario usuario)
        {
            _repository.InserirUsuario(usuario);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _repository.AtualizarUsuario(usuario);
        }

        public void RemoverUsuario(Usuario usuario)
        {
            _repository.RemoverUsarios(usuario);
        }
    }
}
