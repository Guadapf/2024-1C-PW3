using Clase4.MVC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.MVC.Servicios;

public interface IDiaInternacionalService
{
    List<DiaInternacional> ObtenerDiasInternacionales();
    bool EsDiaInternacional(int dia, int mes);
}
public class DiaInternacionalService : IDiaInternacionalService
{
    public static List<DiaInternacional> dias = new();
    
    public DiaInternacionalService()
    {
        if(dias.Count == 0)
        {
            dias.Add(new DiaInternacional { Fecha = new DateTime(DateTime.Now.Year, 3, 8), Nombre = "Día Internacional de la Mujer", Descripcion = "Celebración de la mujer" });
            dias.Add(new DiaInternacional { Fecha = new DateTime(DateTime.Now.Year, 5, 1), Nombre = "Día Internacional del Trabajador", Descripcion = "Celebración del trabajador" });
            dias.Add(new DiaInternacional { Fecha = new DateTime(DateTime.Now.Year, 6, 5), Nombre = "Día Mundial del Medio Ambiente", Descripcion = "Promover la conciencia sobre el medio ambiente" });
            dias.Add(new DiaInternacional { Fecha = new DateTime(DateTime.Now.Year, 9, 21), Nombre = "Día Internacional de la Paz", Descripcion = "Promover la paz en todo el mundo" });
            dias.Add(new DiaInternacional { Fecha = new DateTime(DateTime.Now.Year, 10, 5), Nombre = "Día Mundial de los Docentes", Descripcion = "Celebrar el papel de los docentes en la educación" });
            dias.Add(new DiaInternacional { Fecha = new DateTime(DateTime.Now.Year, 11, 20), Nombre = "Día Universal del Niño", Descripcion = "Promover el bienestar de los niños" });
            dias.Add(new DiaInternacional { Fecha = new DateTime(DateTime.Now.Year, 12, 10), Nombre = "Día Internacional de los Derechos Humanos", Descripcion = "Promover la igualdad, la justicia y la dignidad humana" });
        }
    }
    public List<DiaInternacional> ObtenerDiasInternacionales()
    {
        return dias;
    }

    public bool EsDiaInternacional(int dia, int mes)
    {
        return dias.Any(d => d.Fecha.Day == dia && d.Fecha.Month == mes);
    }
}
