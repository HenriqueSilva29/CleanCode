using backend.Core.Entities;
using backend.Data.Dto;

namespace backend.Core.Interfaces
{
    public interface IReceita
    {
        public Task<Response<List<Receita>>> GetAsync();
        public Task<Response<Receita>> GetAsync(string id);
        public Task<Response<string>> CreateAsync(Receita receita);
        public Task<Response<string>> UpdateAsync(string id, Receita receita);
        public Task<Response<string>> RemoveAsync(string id);
    }
}
