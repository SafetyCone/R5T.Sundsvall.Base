using System;
using System.Collections.Generic;

using R5T.Corcyra;
using R5T.Endalia;


namespace R5T.Sundsvall
{
    public interface IEndpointRepository
    {
        EndpointIdentity New();

        EndpointInfo GetInfo(EndpointIdentity identity);
        IEnumerable<EndpointInfo> GetAllInfos();

        void SetEndpointType(EndpointIdentity endpoint, EndpointTypeIdentity endpointType);
        EndpointTypeIdentity GetEndpointType(EndpointIdentity endpoint);

        void SetEndpointIdentityForCatchment(CatchmentIdentity catchment, EndpointIdentity endpoint);
        EndpointIdentity GetEndpointIdentityForCatchment(CatchmentIdentity catchment);
    }
}
