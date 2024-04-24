﻿using Clase4.MVC.Entidades;

namespace Clase4.MVC.Web.Models;

public class DiaInternacionalModel
{
    public DateTime Fecha { get; set; }
    public string NombreDia { get; set; }
    public string Descripcion { get; set; }

    public DiaInternacionalModel(DiaInternacional diaInternacional)
    {
        Fecha = diaInternacional.Fecha;
        NombreDia = diaInternacional.NombreDia;
        Descripcion = diaInternacional.Descripcion;
    }

    public static List<DiaInternacionalModel> MapToModel(List<DiaInternacional> diasInternacionales)
    {
        return diasInternacionales.Select(d => new DiaInternacionalModel(d)).ToList();
    }
}