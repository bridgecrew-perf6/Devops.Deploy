using Devops.Deploy.Records;
using System;
using System.Collections.Generic;

namespace Devops.Deploy.Interfaces
{
    public interface IRelease
    {
        string Id { get;  }
        string Version { get; }
        DateTime Created { get;  }

        IEnumerable<object> Environments { get;  }
        IEnumerable<object> Deployments { get;  }

        public ReleaseRecord releaseRecord { get; set; }
        public IEnumerable<EnvironmentRecord> environmentRecord { get; set; }
        public IEnumerable<DeploymentRecord> deploymentRecord { get; set; }
    }
}
