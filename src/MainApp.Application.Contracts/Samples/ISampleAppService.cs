using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MainApp.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
