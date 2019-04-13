using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Poc2.Controllers
{
    [Route("api/[controller]")]
    public class CargasController : Controller
    {
        [Authorize("Bearer")]
        [HttpGet("{id}")]
        public Cargas Get(
            [FromServices]CargasDAO CargasDAO,
            string id)
        {
            return CargasDAO.Obter(id);
        }
    }
}
