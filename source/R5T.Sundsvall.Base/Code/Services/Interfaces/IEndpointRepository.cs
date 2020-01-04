using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Corcyra;
using R5T.Endalia;


namespace R5T.Sundsvall
{
    public interface IEndpointRepository
    {
        EndpointIdentity New();

        EndpointIdentity AddByName(EndpointInfo endpointInfo);

        EndpointInfo GetInfo(EndpointIdentity identity);
        IEnumerable<EndpointInfo> GetAllInfos();

        Task SetNameAsync(EndpointIdentity endpoint, string name);

        void SetEndpointType(EndpointIdentity endpoint, EndpointTypeIdentity endpointType);
        Task SetEndpointTypeAsync(EndpointIdentity endpoint, EndpointTypeIdentity endpointType);
        EndpointTypeIdentity GetEndpointType(EndpointIdentity endpoint);

        Task<bool> CatchmentHasEndpoint(CatchmentIdentity catchmentIdentity);

        void SetEndpointForCatchment(CatchmentIdentity catchment, EndpointIdentity endpoint);
        EndpointIdentity GetEndpointForCatchment(CatchmentIdentity catchment);
    }
}
