using System;

using R5T.Endalia;


namespace R5T.Sundsvall
{
    public static class EndpointTypeRepositoryExtensions
    {
        public static void Add(this IEndpointTypeRepository repository, string name)
        {
            var endpointTypeInfo = new EndpointTypeInfo()
            {
                Identity = EndpointTypeIdentity.GetNewGuid(),
                Name = name,
            };

            repository.Add(endpointTypeInfo);
        }
    }
}
