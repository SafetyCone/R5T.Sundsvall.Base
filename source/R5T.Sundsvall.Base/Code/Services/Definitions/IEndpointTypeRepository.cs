using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Endalia;

using R5T.T0064;


namespace R5T.Sundsvall
{
    [ServiceDefinitionMarker]
    public interface IEndpointTypeRepository : IServiceDefinition
    {
        Task<EndpointTypeIdentity> New();

        Task Add(EndpointTypeInfo endpointType);

        Task<bool> Exists(EndpointTypeIdentity identity);

        Task<EndpointTypeInfo> GetInfo(EndpointTypeIdentity identity);
        Task<IEnumerable<EndpointTypeInfo>> GetAllInfos();

        Task SetName(EndpointTypeIdentity identity, string name);
        Task<string> GetName(EndpointTypeIdentity identity);

        Task Delete(EndpointTypeIdentity identity);
    }
}
