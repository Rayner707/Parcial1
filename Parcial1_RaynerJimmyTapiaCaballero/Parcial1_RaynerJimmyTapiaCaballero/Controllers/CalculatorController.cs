using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Parcial1_RaynerJimmyTapiaCaballero.Controllers
{
    public class CalculatorController : ApiController
    {
        public int Add(int numa, int numb)
        {
            return numa + numb;
        }
    }
}
