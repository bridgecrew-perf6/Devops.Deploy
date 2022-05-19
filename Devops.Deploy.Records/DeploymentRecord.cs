using System;

namespace Devops.Deploy.Records
{
    public record DeploymentRecord(string Id, string ReleaseId, string EnvironmentId, DateTime DeployedAt)
    {

      
    }
}
