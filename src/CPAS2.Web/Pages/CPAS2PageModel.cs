using CPAS2.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CPAS2.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class CPAS2PageModel : AbpPageModel
    {
        protected CPAS2PageModel()
        {
            LocalizationResourceType = typeof(CPAS2Resource);
        }
    }
}