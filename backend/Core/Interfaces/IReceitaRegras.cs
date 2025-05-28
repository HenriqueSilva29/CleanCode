using backend.Application.DTOs;
using backend.Core.Entities;
using backend.Data.Dto;

namespace backend.Core.Rules
{
    public interface IReceitaRegras
    {
        Task<Response<string>> GerarReceita(GerarReceitaDto receita);
        Task<Response<List<Receita>>> TodasReceitas();
        Task<Response<string>> AtualizarReceita(string id, ReceitaDto receita);
        Task<Response<string>> RemoveAsync(string id);
        Task<Response<Receita>> Receita(string id);
    }
}
