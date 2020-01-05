using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Endalia;


namespace R5T.Sundsvall
{
    public interface IEndpointTypeRepository
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
