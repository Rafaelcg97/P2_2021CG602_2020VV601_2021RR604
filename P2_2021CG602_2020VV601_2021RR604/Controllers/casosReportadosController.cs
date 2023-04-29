﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2021CG602_2020VV601_2021RR604.Models;

namespace P2_2021CG602_2020VV601_2021RR604.Controllers
{
    public class casosReportadosController : Controller
    {
        private readonly ParcialBDContext _parcialBDContext;

        public casosReportadosController(ParcialBDContext parcialBDContext)
        {
            _parcialBDContext = parcialBDContext;
        }
        public IActionResult Index()
        {
            var listaDeDepartamentos = (from m in _parcialBDContext.departamentos select m).ToList();
            ViewData["listadoDeDepartamentos"] = new SelectList(listaDeDepartamentos, "idDepartamento", "nombreDepartamento");

            var listaDeGeneros = (from m in _parcialBDContext.generos select m).ToList();
            ViewData["listadoDeGeneros"] = new SelectList(listaDeGeneros, "idGenero", "nombreGenero");

            return View();
        }
    }
}
