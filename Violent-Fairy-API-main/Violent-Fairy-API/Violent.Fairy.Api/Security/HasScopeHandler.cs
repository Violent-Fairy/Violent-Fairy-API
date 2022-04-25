using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore. Authorization;

namespace Violent.Fairy.Api.Security
{
    public class HasScopeHandler : AuthorizationHandler<HasScopeRequirements>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HasScopeRequirements requirement)
        {
            
            if (!context.User.Hasclaim(c => c.Type == "scope" && c.Issuer == requirment.Issuer))
                return Task.CompletedTask;

            var scopes = context.User
                .FindFirst(c => c.Type == "scope" && c.Issuer == requirement.Issuer)
                .Value.Split(' ');

            if (scopes.Any(s => s == requirement.Scope))
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}