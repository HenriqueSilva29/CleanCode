using backend.Application.DTOs;
using backend.Core.Entities;
using backend.Core.Enums;

namespace backend.Application.Mappers
{
    /// <summary>
    /// Responsável por converter um DTO de entrada em uma entidade de domínio Receita.
    /// </summary>
    public static class GerarReceitaMapper
    {
       public static Receita ToEntity(GerarReceitaDto dto, 
                                      Dictionary<string, Dictionary<string, string>> ingredientesGerados, 
                                      Dictionary<string, Dictionary<string, string>> preparoGerado)
        {
            return new Receita
            {
                Id = Guid.NewGuid().ToString(),
                Titulo = "Receita Gerada por IA",
                Dificuldade = dto.Dificuldade, 
                PorcaoPessoas = int.TryParse(dto.PorcaoPessoas, out var porcao)
                                    ? porcao
                                    : 1,
                Ingredientes = ingredientesGerados,
                Preparo = preparoGerado,
                Observacao = "Sugestão gerada com base nos ingredientes informados"
            };
        }
    }
}
