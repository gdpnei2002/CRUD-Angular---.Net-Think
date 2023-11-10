using System.Threading.Tasks;
using Abp.Application.Services;
using projet.Sessions.Dto;

namespace projet.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
