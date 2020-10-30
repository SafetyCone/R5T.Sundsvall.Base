using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Corcyra;
using R5T.Endalia;


namespace R5T.Sundsvall
{
    public interface IEndpointRepository
    {
        Task<EndpointIdentity> New();

        Task<EndpointIdentity> AddByName(EndpointInfo endpointInfo);

        Task<EndpointInfo> GetInfo(EndpointIdentity identity);
        Task<IEnumerable<EndpointInfo>> GetAllInfos();

        Task SetNameAsync(EndpointIdentity endpoint, string name);

        Task SetEndpointType(EndpointIdentity endpoint, EndpointTypeIdentity endpointType);
        Task SetEndpointTypeAsync(EndpointIdentity endpoint, EndpointTypeIdentity endpointType);
        Task<EndpointTypeIdentity> GetEndpointType(EndpointIdentity endpoint);

        // TODO: DEPRECATE THE BELOW
        Task<bool> CatchmentHasEndpoint(CatchmentIdentity catchmentIdentity);
        Task<bool> EndpointHasCatchment(EndpointIdentity endpointIdentity);
        Task SetEndpointForCatchment(CatchmentIdentity catchment, EndpointIdentity endpoint);
        Task<EndpointIdentity> GetEndpointForCatchment(CatchmentIdentity catchment);
        Task<CatchmentIdentity> GetCatchmentForEndpoint(EndpointIdentity endpointIdentity);
    }
}
