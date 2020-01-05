using System;
using System.Threading.Tasks;

using R5T.Corcyra;
using R5T.Endalia;


namespace R5T.Sundsvall
{
    public static class IEndpointRepositoryExtensions
    {
        public static async Task<EndpointInfo> GetInfo(this IEndpointRepository repository, Guid identity)
        {
            var endpointInfo = await repository.GetInfo(new EndpointIdentity(identity));
            return endpointInfo;
        }

        public static async Task<EndpointInfo> GetInfoForCatchment(this IEndpointRepository repository, CatchmentIdentity catchmentIdentity)
        {
            var endpointIdentityForCatchment = await repository.GetEndpointForCatchment(catchmentIdentity);

            var endpointInfo = await repository.GetInfo(endpointIdentityForCatchment);
            return endpointInfo;
        }

        public static async Task SetCatchmentForEndpoint(this IEndpointRepository repository, EndpointIdentity endpointIdentity, CatchmentIdentity catchmentIdentity)
        {
            await repository.SetEndpointForCatchment(catchmentIdentity, endpointIdentity);
        }
    }
}
