﻿using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IDetalleCompraRepository
    {
        Task<List<DetalleCompra>> GetAll();
        Task<DetalleCompra> GetById(int id);
        void Insert(DetalleCompra compra);

        void Update(DetalleCompra compra);

        void Delete(int id);

        Task<List<DetalleComprasDto>> ObtenerDetalleCompra(int idCompra);

        Task<DetalleCompra> GetByOrderSecuenciaCompra(int? orderSecuencia, int? IdCompra);

        Task DeleteListDetalleCompra(int idCompra);
    }
}
