using Database;
using Domain.Entity;
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
            Audit audit = new Audit();
            audit.Date = DateTime.Now;
            audit.Identification = 12345;
            connection.insertAudit(audit);

            CalculateTravels calculateTravels = new CalculateTravels();


            return calculateTravels.calculate(rawInfo);
        }
    }
}
