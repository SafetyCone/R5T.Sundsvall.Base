using System;
using System.Collections.Generic;

using R5T.Endalia;


namespace R5T.Sundsvall
{
    public interface IEndpointTypeRepository
    {
        EndpointTypeIdentity New();

        void Add(EndpointTypeInfo endpointType);

        bool Exists(EndpointTypeIdentity identity);

        EndpointTypeInfo GetInfo(EndpointTypeIdentity identity);
        IEnumerable<EndpointTypeInfo> GetAllInfos();

        void SetName(EndpointTypeIdentity identity, string name);
        string GetName(EndpointTypeIdentity identity);

        void Delete(EndpointTypeIdentity identity);
    }
}
