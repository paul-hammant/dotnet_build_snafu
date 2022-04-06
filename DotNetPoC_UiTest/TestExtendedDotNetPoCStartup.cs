using Microsoft.Extensions.Configuration;

namespace DotNetPoC.UiTest
{
    public class TestExtendedDotNetPoCStartup : DotNetPoCStartup
    {
        public TestExtendedDotNetPoCStartup(IConfiguration configuration) : base(configuration)
        { 
            // we could do some magic override-for-testing-purposes here
        }
        
        // or here
    }
}