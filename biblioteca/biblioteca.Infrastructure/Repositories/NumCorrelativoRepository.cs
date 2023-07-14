
using biblioteca.Domain.Entities;
using biblioteca.Domain.Repository;
using biblioteca.Infrastructure.Context;
using biblioteca.Infrastructure.Core;
using biblioteca.Infrastructure.Exceptions;
using biblioteca.Infrastructure.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using biblioteca.Infrastructure.Extentions;

namespace biblioteca.Infrastructure.Repositories
{
    public class NumCorrelativoRepository : BaseRepository<NumeroCorrelativo>, IRepositoryBase<NumeroCorrelativo>
    {
     
            private readonly ILogger<NumCorrelativoRepository> logger;
            private readonly BibliotecaContext context;

            public NumCorrelativoRepository(ILogger<PrestamoRepository> logger,
                                           BibliotecaContext context) : base(context)
            {
                this.logger = logger;
                this.context = context;
            }

            public override void Guardar(NumeroCorrelativo entity)
            {
                if (this.Exists(cd => cd.IdNumeroCorrelativo == entity.IdNumeroCorrelativo))

                    throw new NumCorrelativoException("EL prestamo ya existe");

                base.Guardar(entity);
                base.SaveChanges();
            }

            public override void Actualizar(NumeroCorrelativo entity)
            {
                try
                {
                    NumeroCorrelativo correlativoActualizar = base.TraerEntityporId(entity.IdNumeroCorrelativo);

                    if (correlativoActualizar is null)
                        throw new PrestamoException("El prestamo no existe.");

                    correlativoActualizar.IdNumeroCorrelativo = entity.IdNumeroCorrelativo;
                    correlativoActualizar.Prefijo = entity.Prefijo;
                    correlativoActualizar.UltimoNumero = entity.UltimoNumero;
                    correlativoActualizar.Tipo = entity.Tipo;
                    correlativoActualizar.FechaRegistro = DateTime.Now;
                    

                    base.Actualizar(correlativoActualizar);
                    base.SaveChanges();
                }
                catch (Exception ex)
                {
                    this.logger.LogError("Error al actualizar el Numero correlativo", ex.ToString());
                }
            }

            public override void Eliminar(NumeroCorrelativo entity)
            {

                try
                {

                      NumeroCorrelativo correlativoEliminar = base.TraerEntityporId(entity.IdNumeroCorrelativo);

                    if (correlativoEliminar is null)
                        throw new PrestamoException("El prestamo no existe.");

                    correlativoEliminar.FechaRegistro = DateTime.Now;
                    correlativoEliminar.UltimoNumero = entity.UltimoNumero;
                   

                    base.Actualizar(correlativoEliminar);
                    base.SaveChanges();

                }
                catch (Exception ex)
                {

                    this.logger.LogError("Error al elimminar el prestamo", ex.ToString());
                }
            }

            public List<NumCorrelativoModel> ObtenerNumeroCorrelativo(int IdNumeroCorrelativo)
            {
                List<NumCorrelativoModel> numcorrelativo = new List<NumCorrelativoModel>();

                try
                {
                this.logger.LogInformation($"Info. del prestamo aquí: {IdNumeroCorrelativo}");

                numcorrelativo = (from nc in base.GetEntities()
                                  select new NumCorrelativoModel()
                                  {
                                      NumeroCorrelativoID = nc.IdNumeroCorrelativo,
                                      prefijo = nc.Prefijo,
                                      ultimoNumero = nc.UltimoNumero,
                                      fechaRegistro = nc.FechaRegistro,
                                      tipo = nc.Tipo


                                  }).ToList();

                }
                catch (Exception)
                {
                }

            }

            public List<NumCorrelativoModel> ObtenerNumcorrelativo()
            {
                throw new NotImplementedException();
            }

            public NumCorrelativoModel obtenerNumeroCorrelativo(int IdNumeroCorrelativo)
            {
                NumCorrelativoModel correlativoModel = new NumCorrelativoModel();
                try
                {
                    correlativoModel = base.TraerEntityporId(IdNumeroCorrelativo).ConvertirNumCorrelativoEntityaModel();

                }
                catch (Exception ex)
                {
                    this.logger.LogError("Error obteniendo el Numero Correllativo", ex.ToString());
                }
                return correlativoModel;
            }
        }

    }
}
