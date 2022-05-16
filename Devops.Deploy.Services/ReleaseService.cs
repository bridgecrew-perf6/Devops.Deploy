using Devops.Deploy.Extensions;
using Devops.Deploy.Interfaces;
using System;

namespace Devops.Deploy.Services
{
    public class ReleaseService : IReleaseService
    {
        public ReleaseService()
        {

        }
        public void Foo(IRelease release)
        {
            release.Foo();
        }
    }
}
