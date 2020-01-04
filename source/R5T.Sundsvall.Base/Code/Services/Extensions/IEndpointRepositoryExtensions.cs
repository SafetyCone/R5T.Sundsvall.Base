using System;

using R5T.Corcyra;
using R5T.Endalia;


namespace R5T.Sundsvall
{
    public static class IEndpointRepositoryExtensions
    {
        public static EndpointInfo GetInfo(this IEndpointRepository repository, Guid identity)
        {
            var endpointInfo = repository.GetInfo(new EndpointIdentity(identity));
            return endpointInfo;
        }

        public static EndpointInfo GetInfoForCatchment(this IEndpointRepository repository, CatchmentIdentity catchmentIdentity)
        {
            var endpointIdentityForCatchment = repository.GetEndpointForCatchment(catchmentIdentity);

            var endpointInfo = repository.GetInfo(endpointIdentityForCatchment);
            return endpointInfo;
        }
    }
}
