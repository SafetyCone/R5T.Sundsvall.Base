using System;
using System.Collections.Generic;

using R5T.Corcyra;
using R5T.Endalia;


namespace R5T.Sundsvall
{
    public interface IEndpointRepository
    {
        EndpointIdentity New();

        void AddByName(EndpointInfo endpointInfo);

        EndpointInfo GetInfo(EndpointIdentity identity);
        IEnumerable<EndpointInfo> GetAllInfos();

        void SetEndpointType(EndpointIdentity endpoint, EndpointTypeIdentity endpointType);
        EndpointTypeIdentity GetEndpointType(EndpointIdentity endpoint);

        void SetEndpointForCatchment(CatchmentIdentity catchment, EndpointIdentity endpoint);
        EndpointIdentity GetEndpointForCatchment(CatchmentIdentity catchment);
    }
}
