using Database;
using Domain.Order;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateTravelsController : ControllerBase
    {
        [HttpPost]
        public IEnumerable<Output> post(RawInfo rawInfo)
        {
            ConnectionAudit connection = new ConnectionAudit();

            rawInfo.Date = DateTime.Now;
            connection.insertAudit(rawInfo);

            CalculateTravels calculateTravels = new CalculateTravels();


            return calculateTravels.calculate(rawInfo);
        }
    }
}
