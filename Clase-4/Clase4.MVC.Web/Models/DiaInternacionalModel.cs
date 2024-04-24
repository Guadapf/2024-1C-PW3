using Clase4.MVC.Entidades;

namespace Clase4.MVC.Web.Models;

public class DiaInternacionalModel
{
    public DateTime Fecha { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public bool EsDiaInternacional { get; set; }

    public DiaInternacionalModel(DiaInternacional diaInternacional)
    {
        Fecha = diaInternacional.Fecha;
        Nombre = diaInternacional.Nombre;
        Descripcion = diaInternacional.Descripcion;
        EsDiaInternacional = true;
    }

    public static List<DiaInternacionalModel> MapToModel(List<DiaInternacional> diasInternacionales)
    {
        return diasInternacionales.Select(d => new DiaInternacionalModel(d)).ToList();
    }
}
