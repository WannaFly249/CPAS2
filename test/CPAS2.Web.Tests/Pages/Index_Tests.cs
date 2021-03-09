using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CPAS2.Pages
{
    public class Index_Tests : CPAS2WebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
