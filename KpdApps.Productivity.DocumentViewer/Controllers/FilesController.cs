using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KpdApps.Productivity.DocumentViewer.DataConnections.Interfaces;
using KpdApps.Productivity.DocumentViewer.DataConnections;
using KpdApps.Productivity.DocumentViewer.DataConnections.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KpdApps.Productivity.DocumentViewer.Controllers
{
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            IFileDataConnector connector = FileDataConnectorFactory.GetConnector(FileDataConnectorTypes.Dummy);
            FilesDataContract files = connector.GetFiles();
            return new JsonResult(files);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
