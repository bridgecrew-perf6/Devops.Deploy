using Devops.Deploy.Interfaces;

namespace Devops.Deploy.Clients
{
    public class ReleaseClient
    {

        public IReleaseService releaseService;
        public IRelease release;

        public ReleaseClient(IReleaseService releaseService, IRelease release)
        {
            this.releaseService = releaseService;
            this.release = release;
        }
    }
}
