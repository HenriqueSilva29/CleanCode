using backend.Application.DTOs;
using backend.Core.Entities;
using backend.Core.Rules;
using backend.Data.Dto;

namespace backend.Services
{
    public class ReceitaServices : IReceitaRegras
    {

        private readonly IReceitaRegras _receitaRegras;

        public ReceitaServices(IReceitaRegras receitaRegras)
        {
            _receitaRegras = receitaRegras;
        }  

        public async Task<Response<string>> GerarReceita(GerarReceitaDto receita)
        {
            return await _receitaRegras.GerarReceita(receita);               
        }

        public async Task<Response<List<Receita>>> TodasReceitas()
        {
            return await _receitaRegras.TodasReceitas();
        }

        public async Task<Response<string>> AtualizarReceita(string id, ReceitaDto receita)
        {
            return await _receitaRegras.AtualizarReceita(id, receita);
        }

        public async Task<Response<string>> RemoveAsync(string id)
        {
            return await _receitaRegras.RemoveAsync(id);
        }

        public async Task<Response<Receita>> Receita(string id)
        {
            return await _receitaRegras.Receita(id);
        }
    }
}
