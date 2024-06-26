using WebApp.SingleLayer.Localization;
using Volo.Abp.Application.Services;

namespace WebApp.SingleLayer.Services;

/* Inherit your application services from this class. */
public abstract class SingleLayerAppService : ApplicationService
{
    protected SingleLayerAppService()
    {
        LocalizationResource = typeof(SingleLayerResource);
    }
}