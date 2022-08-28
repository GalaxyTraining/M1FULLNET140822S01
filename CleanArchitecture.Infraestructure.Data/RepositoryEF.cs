﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infraestructure.Data
{
    public class RepositoryEF<T>:IRepositoryEF<T> where T : class
    {
        protected readonly DbContext _context;
        public RepositoryEF(DbContext context)
        {
            _context = context;
        }
        public async Task<List<T>> GetAll()
        {
             return  await _context.Set<T>().ToListAsync();
        }
        public async Task<T> GetEntityById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public async Task<bool> Update(T entity)
        {
            _context.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Delete(T entity)
        {
            _context.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<T> Obtener<T>(Expression<Func<T,bool>> condicion) where T:class
        {
            return await _context.Set<T>().FirstOrDefaultAsync(condicion);
        }
        public async Task<int> Insert(T entity)
        {
            _context.Add(entity);
            return await _context.SaveChangesAsync();
        }
    }
}