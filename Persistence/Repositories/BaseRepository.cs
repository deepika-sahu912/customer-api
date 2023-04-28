using System;
using Application.Contracts;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;


namespace Persistence.Repositories
{

	
    public class BaseRepository<T> : IBaseRepository <T> where T : class
	{

        private readonly CustomerContext _customerContexts;

        public BaseRepository(CustomerContext customerContexts)
        {
            _customerContexts = customerContexts;
        }

        public async Task<string> AddAsync(T entity)
        {
            await _customerContexts.Set<T>().AddAsync(entity);
            await _customerContexts.SaveChangesAsync();

            return (string.Format("Record has been successfully created for customer"));

        }

        public async Task<List<T>> GetAsync()
        {
            return await _customerContexts.Set<T>().ToListAsync();
        }


        public async Task<string> UpdateAsync(T entity)
        {
            _customerContexts.Entry(entity).State = EntityState.Modified;
            await _customerContexts.SaveChangesAsync();

            return (string.Format("Record has been successfully updated for customer"));
        }

        public async Task<string> DeleteAsync(T entity)
        {
            _customerContexts.Set<T>().Remove(entity);
            await _customerContexts.SaveChangesAsync();

            return (string.Format("Record has been successfully deleted for customer"));
        }

        public async Task<T>? FindAsyncById(int id)
        {
            var entity = await _customerContexts.Set<T>().FindAsync(id);
            return entity;
           
        }

    }
}

