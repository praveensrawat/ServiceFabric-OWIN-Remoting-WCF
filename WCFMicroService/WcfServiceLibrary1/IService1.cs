using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;



namespace WcfServiceLibrary1
{

    using Microsoft.ServiceFabric.Services.Remoting;
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IConnector2" in both code and config file together.
    [ServiceContract]
    public interface IConnector2:IService
    {
        [OperationContract]
        Task<bool> CloseSession(Guid clientSessionId);

        // TODO: Add your service operations here
    }

 
}
