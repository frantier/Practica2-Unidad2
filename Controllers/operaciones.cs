using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calculadora_colores_resistencias.Api.Domain;

/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Servicios
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Actividad 2
Nombre del alumno: Pedro Victor Ruvalcaba Novelo
Cuatrimestre: 4
Grupo: B
Parcial: 2
*/

namespace Calculadora_colores_resistencias.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class operaciones : ControllerBase
    {
        [HttpGet("CaluladoradeBandas")]
        public ActionResult<colores> Aritmetica (string B1, string B2, string B3, string B4)
        {
            colores BND = new colores();

                BND.Colors = B1;

                var Txt = "";

                switch (BND.Colors)
            {
                case "Negro":
                BND.V1 = 0;
                break;
                case "Cafe":
                BND.V1 = 1;
                break;
                case "Rojo":
                BND.V1 = 2;
                break;
                case "Naranja":
                BND.V1 = 3;
                break;
                case "Amarillo":
                BND.V1 = 4;
                break;
                case "Verde":
                BND.V1 = 5;
                break;
                case "Azul":
                BND.V1 = 6;
                break;
                case "Violeta":
                BND.V1 = 7;
                break;
                case "Gris":
                BND.V1 = 8;
                break;
                case "Blanco":
                BND.V1 = 9;
                break;
                default:
                Txt = $"El color ingresado '{B1}' no es correcto, vuele a intentar";
                return Ok(Txt);
            }

            var c1 = BND.V1;

            BND.Colors = B2;

            switch (BND.Colors)
            {
                case "Negro":
                BND.V1 = 0;
                break;
                case "Cafe":
                BND.V1 = 1;
                break;
                case "Rojo":
                BND.V1 = 2;
                break;
                case "Naranja":
                BND.V1 = 3;
                break;
                case "Amarillo":
                BND.V1 = 4;
                break;
                case "Verde":
                BND.V1 = 5;
                break;
                case "Azul":
                BND.V1 = 6;
                break;
                case "Violeta":
                BND.V1 = 7;
                break;
                case "Gris":
                BND.V1 = 8;
                break;
                case "Blanco":
                BND.V1 = 9;
                break;
                default:
                return Ok(Txt);
            }

            var c2 = BND.V1;

            BND.Colors = B3;

                switch (BND.Colors)
            {
                case "Negro":
                BND.V2 = 1;
                break;
                case "Cafe":
                BND.V2 = 10;
                break;
                case "Rojo":
                BND.V2 = 100;
                break;
                case "Naranja":
                BND.V2 = 1000;
                break;
                case "Amarillo":
                BND.V2 = 10000;
                break;
                case "Verde":
                BND.V2 = 100000;
                break;
                case "Azul":
                BND.V2 = 1000000;
                break;
                case "Dorado":
                BND.V2 = 10;
                break;
                case "Plateado":
                BND.V2 = 100;
                break;
                default:
                return Ok(Txt);
            }

            var c3 = BND.V2;

                BND.Colors = B4;

                switch (BND.Colors)
            {

                case "Dorado":
                BND.V1 = 5;
                break;
                case "Plateado":
                BND.V1 = 10;
                break;
                default:
                return Ok(Txt);
            
            }

            var c4 = BND.V1;
            
            float OperacionFinal;

            var N1  = Int32.Parse($"{c1}{c2}");

            if (B3 == "Dorado" || B3 == "Plateado")
            {
                OperacionFinal = (N1 / c3);
            }
            else
            {
                OperacionFinal = (N1 * c3);
            }

            Txt = "La resistencia es de "+ OperacionFinal +" ohms y tiene una tolerancia de " + c4 + "%";

            return Ok(Txt);
        }

    }
}