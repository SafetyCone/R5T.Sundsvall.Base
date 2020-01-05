using System;
using System.Threading.Tasks;

using R5T.Endalia;


namespace R5T.Sundsvall
{
    public static class EndpointTypeRepositoryExtensions
    {
        public static async Task Add(this IEndpointTypeRepository repository, string name)
        {
            var endpointTypeInfo = new EndpointTypeInfo()
            {
                Identity = EndpointTypeIdentity.GetNewGuid(),
                Name = name,
            };

            await repository.Add(endpointTypeInfo);
        }
    }
}
