
using IdentityServer4.Models;
using System.Security;
using IdentityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Test;

namespace OAuthProjectDockAPI.Configuration
{
    public class InMemoryConfiguration
    {
        public static IEnumerable<ApiResource> ApiResources()
        {
            return new[]
            {
                new ApiResource("socialnatwork" , "Social Network")
            };
        }
        public static IEnumerable<Client> Clients()
        {
            return new[]
            {
                new Client
                {
                       ClientId = "socialnetwork",
                       ClientSecrets = new[]{ new Secret("secret".Sha256())},
                       AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                       AllowedScopes = new[] { "socialnetwork" }

                }
            };
        } 
        public static IEnumerable<TestUser> Users()
        {
            return new[]
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "dimoilenov@gmail.com",
                    Password = "123456"
                }
            };
        }
    }
}
