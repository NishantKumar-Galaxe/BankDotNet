using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfDotNet.IdentityServer
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetAllApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("BankOfDotNetAPI","Customer API for BankOfDotNet")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId= "client",
                    AllowedGrantTypes= GrantTypes.ClientCredentials,
                    ClientSecrets=
                    {
                        new Secret("password".Sha256())
                    },
                    AllowedScopes={ "BankOfDotNetAPI" }
                }
            };
        }
    }
}
