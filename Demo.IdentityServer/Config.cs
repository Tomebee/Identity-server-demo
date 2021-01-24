// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace Demo.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("api", "Api")
            };

        public static IEnumerable<ApiResource> ApiResources =>
          new ApiResource[]
          {
               new ApiResource("api", "Api")
          };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                     ClientId = "api",
                     AllowedGrantTypes = GrantTypes.ClientCredentials,
                     ClientSecrets =
                     {
                        new Secret("5432090a-2d99-46a9-8994-b5d93c8d2406".Sha256())
                     },
                     AllowedScopes = { "api" }
                },
                new Client
                {
                     ClientId = "clientApp",
                     AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                     AllowRememberConsent = false,
                     RequirePkce = false,
                     RedirectUris = new List<string>()
                     {
                        "https://localhost:53585/signin-oidc"
                     },
                     PostLogoutRedirectUris = new List<string>()
                     {
                        "https://localhost:53585/signout-callback-oidc"
                     },
                     ClientSecrets = new List<Secret>
                     {
                        new Secret("3ed1756f-6503-4a3d-82b8-1ab3c3d6fabf".Sha256())
                     },
                     AllowedScopes = new List<string>
                     {
                         IdentityServerConstants.StandardScopes.OpenId,
                         IdentityServerConstants.StandardScopes.Profile,
                         "api"
                     }

                }

            };
    }
}