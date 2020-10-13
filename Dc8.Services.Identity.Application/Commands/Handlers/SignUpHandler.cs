using Convey.CQRS.Commands;
using Dc8.Services.Identity.Application.Services;
using System.Threading.Tasks;

namespace Dc8.Services.Identity.Application.Commands.Handlers
{
    internal sealed class SignUpHandler : ICommandHandler<SignUp>
    {
        private readonly IIdentityService _identityService;

        public SignUpHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public Task HandleAsync(SignUp command) => _identityService.SignUpAsync(command);
    }
}
