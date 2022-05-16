using System;
using Devops.Deploy.Interfaces;

namespace Devops.Deploy.Clients
{
    public class ProjectClient
    {

        public IProjectService projectService;
        public IProject project;

        public ProjectClient(IProjectService projectService, IProject project)
        {
            this.projectService = projectService;
            this.project = project;
        }
    }
}
