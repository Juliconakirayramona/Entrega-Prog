﻿using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IFacturasRepositorio
    {
        List<Facturas> Listar();
        Facturas Guardar(Facturas entidad);
        Facturas Modificar(Facturas entidad);
        Facturas Borrar(Facturas entidad);
    }
}