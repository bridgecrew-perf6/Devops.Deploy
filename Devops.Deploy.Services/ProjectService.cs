using Devops.Deploy.Extensions;
using Devops.Deploy.Interfaces;
using System;

namespace Devops.Deploy.Services
{
    public class ProjectService : IProjectService
    {
        public ProjectService()
        {

        }
        public void Foo(IProject project)
        {
            project.Foo();
        }
    }
}
