﻿using Algartech.Models;

namespace Algartech.Repository.Contratos
{
    public interface IVentaRepositorio
    {
        Task<Venta> Registrar(Venta entidad);
        Task<List<Venta>> Historial(string buscarPor,string numeroVenta, string fechaInicio, string fechaFin);
        Task<List<DetalleVenta>> Reporte(DateTime FechaInicio, DateTime FechaFin);
    }
}
