using backend.Application.DTOs;
using backend.Core.Entities;

public interface IReceitaRepository
{
    public Task<Response<Receita>> GetAsync(string id);
    public Task<Response<List<Receita>>> GetAllAsync();
    public Task<Response<string>> AddAsync(Receita receita);
    public Task<Response<string>> UpdateAsync(string id, Receita receita);
    public Task<Response<string>> DeleteAsync(string id);
}
