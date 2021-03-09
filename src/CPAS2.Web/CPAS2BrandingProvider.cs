using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CPAS2.Web
{
    [Dependency(ReplaceServices = true)]
    public class CPAS2BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CPAS2";
    }
}
