using System.Collections.Generic;
using System.Web.Http;
using WcfServiceLibrary1;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using System;
using System.Threading.Tasks;

namespace FrontEndGateway.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values         
        public async Task<IEnumerable<bool>> Get()
        {

            //IConnector2 connector2 = ServiceProxy.Create<IConnector2>(new Uri("fabric:/WCFMicroService/WCF1"));
            IConnector2 connector2 = ServiceProxy.Create<IConnector2>(new Uri("fabric:/WCFMicroService/StatefulMicroService1"),new Microsoft.ServiceFabric.Services.Client.ServicePartitionKey(0));
            
            bool returnVal = await connector2.CloseSession( new Guid());
            return new bool[] { returnVal };

        }

        // GET api/values/5 
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}
