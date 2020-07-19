using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Endalia;


namespace R5T.Sundsvall
{
    public interface IEndpointAndTypeRepository
    {
        Task<Dictionary<string, List<EndpointIdentity>>> GetEndpointIdentitiesByEndpointTypeName(IEnumerable<EndpointIdentity> endpointIdentities);
    }
}
