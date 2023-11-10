using System.Threading.Tasks;
using Abp.Application.Services;
using projet.Authorization.Accounts.Dto;

namespace projet.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
