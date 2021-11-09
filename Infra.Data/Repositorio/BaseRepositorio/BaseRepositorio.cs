using Dominio.Interfaces.BaseRepositorio;
using Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositorio.BaseRepositorio
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class, new()
    {
        protected readonly AppContexto _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepositorio(AppContexto context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Adicionar(T entity)
        {
            _dbSet.Add(entity);
            SalvarAlteracao();
        }

        public void Atualizar(T entity)
        {
            _dbSet.Update(entity);
            SalvarAlteracao();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public void Remover(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            SalvarAlteracao();
        }

        public int SalvarAlteracao()
        {
            return _context.SaveChanges();
        }
    }
}
