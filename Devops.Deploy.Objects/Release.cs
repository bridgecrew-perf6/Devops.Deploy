using Devops.Deploy.Interfaces;
using Devops.Deploy.Records;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Devops.Deploy.Objects
{
    public class Release : IRelease
    {
        
        public string Id { get => releaseRecord.Id; }
        public string Version { get => releaseRecord.Version; }
        public DateTime Created { get => releaseRecord.Created; }
        public IEnumerable<object> Environments { get => environmentRecord; }
        public IEnumerable<object> Deployments { get => deploymentRecord; }

        public ReleaseRecord releaseRecord { get; set; }
        public IEnumerable<EnvironmentRecord> environmentRecord { get; set; }
        public IEnumerable<DeploymentRecord> deploymentRecord { get; set; }
    }
}
