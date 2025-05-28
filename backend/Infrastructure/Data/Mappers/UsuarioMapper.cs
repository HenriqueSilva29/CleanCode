using backend.Core.Entities;
using backend.Infrastructure.Data.MongoModels;

namespace backend.Infrastructure.Data.Mappers
{
    public static class UsuarioMapper
    {
        public static Usuario ToDomain(UsuarioDocument doc)
        {
            return new Usuario
            {
                Id = int.TryParse(doc.Id, out var idParsed) ? idParsed : 0,
                Nome = doc.Nome,
                Senha = doc.Senha,
                Email = doc.Email
            };
        }

        public static UsuarioDocument ToDocument(Usuario usuario)
        {
            return new UsuarioDocument
            {
                Id = usuario.Id.ToString(),
                Nome = usuario.Nome,
                Senha = usuario.Senha,
                Email = usuario.Email
            };
        }
    }
}
