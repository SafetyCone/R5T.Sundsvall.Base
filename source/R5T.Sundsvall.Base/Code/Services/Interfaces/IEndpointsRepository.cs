﻿using System;

using R5T.Corcyra;
using R5T.Endalia;


namespace R5T.Sundsvall
{
    public interface IEndpointsRepository
    {
        EndpointIdentity New();

        void SetEndpointType(EndpointIdentity endpoint, EndpointTypeIdentity endpointType);
        EndpointTypeIdentity GetEndpointType(EndpointIdentity endpoint);

        void SetEndpointIdentityForCatchment(CatchmentIdentity catchment, EndpointIdentity endpoint);
        EndpointIdentity GetEndpointIdentityForCatchment(CatchmentIdentity catchment);
    }
}
