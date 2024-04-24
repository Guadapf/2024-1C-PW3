using Clase4.MVC.Servicios;
using Clase4.MVC.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.MVC.Web.Controllers;

public class DiaInternacionalController : Controller
{
    public readonly IDiaInternacionalService _diaInternacionalService;

    public DiaInternacionalController(IDiaInternacionalService diaInternacionalService)
    {
        _diaInternacionalService = diaInternacionalService;
    }

    public IActionResult Index()
    {
        var diasInternacionales = _diaInternacionalService.ObtenerDiasInternacionales();
        return View(DiaInternacionalModel.MapToModel(diasInternacionales));
    }

    public IActionResult EsDiaInternacional(int dia, int mes)
    {
        EsDiaInternacionalModel esDiaInternacionalModel = new EsDiaInternacionalModel
        {
            Dia = dia,
            Mes = mes,
            EsDiaInternacional = _diaInternacionalService.EsDiaInternacional(dia, mes)
        };
        return View(esDiaInternacionalModel);
    }
}
