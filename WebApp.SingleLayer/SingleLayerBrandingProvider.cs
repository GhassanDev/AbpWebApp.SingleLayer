using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace WebApp.SingleLayer;

[Dependency(ReplaceServices = true)]
public class SingleLayerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SingleLayer";
}
