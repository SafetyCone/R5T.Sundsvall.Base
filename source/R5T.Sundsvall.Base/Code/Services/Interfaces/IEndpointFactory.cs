using System;

using R5T.Endalia;


namespace R5T.Sundsvall
{
    public interface IEndpointFactory
    {
        IEndpoint GetEndpoint(EndpointIdentity endpoint);
    }
}
