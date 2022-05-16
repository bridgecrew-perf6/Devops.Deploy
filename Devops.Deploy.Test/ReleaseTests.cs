using Devops.Deploy.Clients;
using Devops.Deploy.Injectors;
using Ninject;
using Xunit;

namespace Devops.Deploy.Tests
{
    public class ReleaseTests
    {
        public ReleaseTests()
        {
            var kernel = new StandardKernel(new GeneralInjector());

            var ReleaseService = kernel.Get<ReleaseClient>().releaseService;
            var Release = kernel.Get<ReleaseClient>().release;
            ReleaseService.Foo(Release);


        }
        // For each **project**/**environment** combination, keep `n` **releases** 
        //that have most recently been deployed, where `n` is the number of releases to keep. 


        //Project has environment
        //ProjectEnvironment has releases
        //clean unmarked releases
        //Release has deployments
        //sort releases according to deploy date desc
        //mark from recent to N




        // A **release** is considered to have "been deployed" if the release _has one or more_ **deployments**.



        //        ##### Test Data
        //| Project-1 | Environment-1 |
        //| ------------- | ------------- |
        //| `Release-1` (Version: `1.0.0`, Created: `2000-01-01T08:00:00`)  | `Deployment-1` (DeployedAt: `2000-01-01T10:00:00`) |

        //##### Expected Result

        //- `Release-1` kept because it was the most recently deployed to `Environment-1`
    }
}
