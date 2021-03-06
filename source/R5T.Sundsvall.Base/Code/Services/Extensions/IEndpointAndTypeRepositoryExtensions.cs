﻿using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.Endalia;
using R5T.Magyar;


namespace R5T.Sundsvall
{
    public static class IEndpointAndTypeRepositoryExtensions
    {
        public static async Task<(bool, string)> HasEndpointTypeName(this IEndpointAndTypeRepository endpointAndTypeRepository, EndpointIdentity endpointIdentity)
        {
            var endpointIdentities = EnumerableHelper.From(endpointIdentity);

            var endpointIdentitiesByEndpointTypeName = await endpointAndTypeRepository.GetEndpointIdentitiesByEndpointTypeName(endpointIdentities);

            var hasEndpointTypeName = endpointIdentitiesByEndpointTypeName.Keys.Count() > 0;
            if (hasEndpointTypeName)
            {
                var endpointTypeName = endpointIdentitiesByEndpointTypeName.Keys.Single();
                return (hasEndpointTypeName, endpointTypeName);
            }

            return (hasEndpointTypeName, null);
        }

        public static async Task<string> GetEndpointTypeName(this IEndpointAndTypeRepository endpointAndTypeRepository, EndpointIdentity endpointIdentity)
        {
            // Purposefully made singular case from plural, even though extra work on creating Dictionary and List objects.

            var endpointIdentities = EnumerableHelper.From(endpointIdentity);

            var endpointIdentitiesByEndpointTypeName = await endpointAndTypeRepository.GetEndpointIdentitiesByEndpointTypeName(endpointIdentities);

            var endpointTypeName = endpointIdentitiesByEndpointTypeName.Keys.Single();
            return endpointTypeName;
        }
    }
}
