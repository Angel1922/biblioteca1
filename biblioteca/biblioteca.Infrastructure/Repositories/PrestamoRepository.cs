
using biblioteca.Domain.Entities;
using biblioteca.Domain.Repository;
using biblioteca.Infrastructure.Context;
using biblioteca.Infrastructure.Core;
using biblioteca.Infrastructure.Exceptions;
using biblioteca.Infrastructure.Interfaces;
using biblioteca.Infrastructure.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using biblioteca.Infrastructure.Extentions;

namespace biblioteca.Infrastructure.Repositories
{
    public class PrestamoRepository : BaseRepository<Prestamo>, INumCorrelativo 
    {
        private readonly ILogger<PrestamoRepository> logger;
        private readonly BibliotecaContext context;

        public PrestamoRepository(ILogger<PrestamoRepository>  logger, 
                                       BibliotecaContext context) : base(context)
        {
            this.logger = logger;
            this.context = context;
        }

        public override void Guardar(Prestamo entity)         {
            if (this.Exists(cd => cd.IdPrestamo == entity.IdPrestamo)) 

                throw new PrestamoException("EL prestamo ya existe");

            base.Guardar(entity);
            base.SaveChanges();
        }

        public override void Actualizar(Prestamo entity)
        {
            try
            {
                Prestamo prestamoActualizar = base.TraerEntityporId(entity.IdPrestamo);

                if (prestamoActualizar is null) 
                    throw new PrestamoException("El prestamo no existe.");
                
                prestamoActualizar.IdLector = entity.IdLector;  
                prestamoActualizar.IdLibro = entity.IdLibro;
                prestamoActualizar.Codigo = entity.Codigo;
                prestamoActualizar.IdEstadoPrestamo = entity.IdEstadoPrestamo;
                prestamoActualizar.FechaCreacion = DateTime.Now;
                prestamoActualizar.Estado = true;
                prestamoActualizar.EstadoEntregado = entity.EstadoEntregado;
                prestamoActualizar.EstadoRecibido = entity.EstadoRecibido;

                base.Actualizar(prestamoActualizar);
                base.SaveChanges();
            }
            catch (Exception ex) 
            {
                this.logger.LogError("Error al actualizar el prestamo", ex.ToString());
            }
        }

        public override void Eliminar(Prestamo entity)
        {

            try
            {

                Prestamo prestamoEliminar = base.TraerEntityporId(entity.IdPrestamo);

                if (prestamoEliminar is null)
                    throw new PrestamoException("El prestamo no existe.");

                prestamoEliminar.IdLector = entity.IdLector;
                prestamoEliminar.FechaDevolucion = DateTime.Now;
                prestamoEliminar.EstadoRecibido = entity.EstadoRecibido;
                prestamoEliminar.FechaConfirmacionDevolucion = DateTime.Now;

                base.Actualizar(prestamoEliminar);
                base.SaveChanges();

            }
            catch (Exception ex) {

                this.logger.LogError("Error al elimminar el prestamo", ex.ToString());
            }
        }

        public List<PrestamoModel> ObtenerPrestamos(int IdPrestamo)
        {
            List<PrestamoModel> prestamos = new List<PrestamoModel>();

            try 
            {
                this.logger.LogInformation($"Info. del prestamo aquí: {IdPrestamo} ");

                prestamos = (from pt in base.GetEntities()
                             select new PrestamoModel()
                             {
                                 PrestamoId = pt.IdPrestamo,
                                 LectorId = pt.IdLector,
                                 LibroId = pt.IdLibro,
                                 Estado = pt.Estado


                             }).ToList();
                               
            }
            catch (Exception)
            {
            }
          
         }

        public List<PrestamoModel> ObtenerNumCorrelativo()
        {
            throw new NotImplementedException();
        }

        public PrestamoModel Obtenerprestamo(int IdPrestamo)
        {
            PrestamoModel prestamoModel = new PrestamoModel();
            try 
            {
                prestamoModel = base.TraerEntityporId(IdPrestamo).ConvertirPrestamoEntityaModel(); 

            }
            catch (Exception ex) 
            {
                this.logger.LogError("Error obteniendo el prestamo", ex.ToString());
            }
            return prestamoModel;
        }
    }
}
