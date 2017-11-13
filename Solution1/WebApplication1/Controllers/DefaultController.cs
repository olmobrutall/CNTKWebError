using CNTK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class DefaultController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            var device = DeviceDescriptor.CPUDevice;
            Console.WriteLine($"======== running LogisticRegression.TrainAndEvaluate using {device.Type} ========");
            LogisticRegression.TrainAndEvaluate(device);

            return new[] { "OK" };
        }
    }
}
