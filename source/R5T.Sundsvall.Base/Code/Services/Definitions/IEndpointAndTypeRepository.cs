using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Endalia;

using R5T.T0064;


namespace R5T.Sundsvall
{
    [ServiceDefinitionMarker]
    public interface IEndpointAndTypeRepository : IServiceDefinition
    {
        Task<Dictionary<string, List<EndpointIdentity>>> GetEndpointIdentitiesByEndpointTypeName(IEnumerable<EndpointIdentity> endpointIdentities);
    }
}
