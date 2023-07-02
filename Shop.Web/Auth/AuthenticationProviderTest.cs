
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Shop.Web.Auth
{
    namespace Shop.WEB.Auth
    {
        public class AuthenticationProviderTest : AuthenticationStateProvider
        {
            public override async Task<AuthenticationState> GetAuthenticationStateAsync()
            {
               // await Task.Delay(3000);
                var anonimous = new ClaimsIdentity();
                var betoUser = new ClaimsIdentity(new List<Claim>
                {
                new Claim("FirstName", "Beto"),
                new Claim("LastName", "Ramos"),
                new Claim(ClaimTypes.Name, "phill94ramos@gamil.com"),
                new Claim(ClaimTypes.Role, "Admin")
                },
                authenticationType: "test");
                return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(betoUser)));
            }
        }
    }

}
