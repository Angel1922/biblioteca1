

using biblioteca.Domain.Repository;
using biblioteca.Infrastructure.Context;
using biblioteca.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace biblioteca.Infrastructure.Core
{
    public abstract class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {

        private readonly BibliotecaContext context;
        private readonly DbSet<TEntity> myDbSet;

        
        public virtual void Actualizar(TEntity entity)
        {
            try
            {
                this.context.Update(entity);
                this.context.SaveChanges();
            }
            catch (PrestamoException)
            {
                throw new PrestamoException("Ha ocurrido un error actualizando el prestamo");
            }
        }

        public virtual void Actualizar(TEntity[] entities)
        {
            try
            {
                this.context.UpdateRange(entities);
                this.context.SaveChanges();
            }
            catch (PrestamoException)
            {
                throw new PrestamoException("Ha ocurrido un error actualizando en el prestamo");
            }
        }

        public virtual void Eliminar(TEntity entity)
        {
            try
            {
                this.myDbSet.Remove(entity);
                this.context.SaveChanges();
            }
            catch (PrestamoException)
            {
                throw new PrestamoException("Ha ocurrido un error eliminando el prestamo");
            }
        }

        public virtual void Eliminar(TEntity[] entities)
        {
            try
            {
                this.myDbSet.RemoveRange(entities);
                this.context.SaveChanges();
            }
            catch (PrestamoException)
            {
                throw new PrestamoException("Ha ocurrido un error eliminando los prestamos");
            }
        }
        public virtual List<TEntity> GetEntities()
        {
            try
            {
                return this.myDbSet.ToList();
            }
            catch (PrestamoException)
            {
                throw new PrestamoException("Ha ocurrido un error enlistando los prestamo");
            }
        }

        public virtual void Guardar(TEntity entity)
        {
            try
            {
                this.myDbSet.Add(entity);
                this.context.SaveChanges();
            }
            catch (PrestamoException)
            {
                throw new PrestamoException("Ha ocurrido un error guardando el prestamo");
            }
        }

        public virtual void Guardar(TEntity[] entities)
        {
            try
            {
                this.myDbSet.AddRange(entities);
                this.context.SaveChanges();
            }
            catch (PrestamoException)
            {
                throw new PrestamoException("Ha ocurrido un error guardando los prestamos");
            }
        }

        public virtual TEntity TraerEntityporId(int Id)
        {
            try
            {
                return this.myDbSet.Find(Id);
            }
            catch (PrestamoException)
            {
                throw new PrestamoException("Ha ocurrido un error encontrando el prestamo");
            }
        }

        public virtual void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public bool Exists(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
