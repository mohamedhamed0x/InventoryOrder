﻿using InventoryOrder.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InventoryOrder.Repository
{
    public class GenericsRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;

        public GenericsRepository(AppDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public void Add(T obj)
        {
            _table.Add(obj);

        }

        public void Delete(int id)
        {
            T _obj = _table.Find(id);
            if (_obj != null)
            {
                _table.Remove(_obj);

            }
        }

        public IEnumerable<T> GetAll(string include = "")
        {
            IQueryable<T> query = _table;
            if (include != "")
                query = query.Include(include);
            return query.ToList();
        }

        public T GetById(int id)
        {
            return _table.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;

        }

        public int CountNumber()
        {
            return _table.Count();
        }

        public List<T> GetGroup(Expression<Func<T, bool>> func)
        {
            List<T> obj = _table.Where(func).ToList();
            return obj;
        }


    }

}
