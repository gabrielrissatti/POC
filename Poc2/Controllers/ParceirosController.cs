using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Poc2.Controllers
{
    [Route("api/[controller]")]
    public class ParceirosController : Controller
    {
        [Authorize("Bearer")]
        [HttpGet("{id}")]
        public Parceiros Get(
            [FromServices]ParceirosDAO ParceirosDAO,
            string id)
        {
            return ParceirosDAO.Obter(id);
        }
    }
}
