﻿using TodoApp.DataAccess.Context;
using TodoApp.DataAccess.Interfaces;
using TodoApp.DataAccess.Repositories;
using TodoApp.Entities.Concrete;

namespace TodoApp.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly TodoContext _context;
        public Uow(TodoContext context)
        {
            _context = context;
        }
        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
