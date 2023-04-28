using System;
using Domain.Models;

namespace Application.Contracts
{
	public interface IBaseRepository <T> where T : class
	{
        Task<string> AddAsync(T entity);

        Task<List<T>> GetAsync();

        Task<string> UpdateAsync(T entity);

        Task<string> DeleteAsync(T entity);

        Task<T>? FindAsyncById(int id);
    }
}

