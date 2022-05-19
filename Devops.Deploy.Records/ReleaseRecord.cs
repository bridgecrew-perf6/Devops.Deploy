using System;

namespace Devops.Deploy.Records
{
    public record ReleaseRecord(string Id, string ProjectId, string Version, DateTime Created)
    {

    }
}
