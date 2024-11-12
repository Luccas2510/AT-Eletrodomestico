using AT_Eletrodomestico.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AT_Eletrodomestico.Controllers
{
    public class EletrodomesticosController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>
            {
                new Geladeira { Marca = "Electrolux", Modelo = "Frost Free", ConsumoEnergetico = 53.5,  CampacidadeLitros = 474, TemFreezer = true},
                new Televisor { Marca = "Samsung", Modelo = "Crystal UHD", ConsumoEnergetico = 145,  TamanhoTela = 50, EhSmart = true},
                new Televisor { Marca = "Philips", Modelo = "43PFG6918/78", ConsumoEnergetico = 130,  TamanhoTela = 43, EhSmart = true},
            };
            return View(eletrodomesticos);
        }
    }
}
