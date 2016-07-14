# ServiceFabric-OWIN-Remoting-WCF
praveensrawat/ServiceFabric-OWIN-Remoting-WCF 

Listing components from the backend to front end.

WCFServiceLibrary1 - Contains the contract only.  WCF based library which contains a WCF [OperationContract]. It also implements IService interface for Service Fabric remoting support.

StatefulMicroService1 - Service fabric StatefulService. This service implements the contract above.

FrontEndGateway - Service fabric StatelessService serving as a front end Web API gateway. It implments the Owin communication listener for self hosting. It connects to the stateful microservice above via remoting. 

Service Client- Consumes the front end stateless service above over HTTP. Demonstrates convention based Web API approach
