using Devops.Deploy.Clients;
using Devops.Deploy.Injectors;
using Ninject;
using Xunit;

namespace Devops.Deploy.Tests
{
    public class ProjectTests
    {
        public ProjectTests()
        {
            var kernel = new StandardKernel(new GeneralInjector());

            var ProjectService = kernel.Get<ProjectClient>().projectService;
            var Project = kernel.Get<ProjectClient>().project;

        }
        //[**Projects**](#project) can have zero or more [**releases**](#release),
        //which can be released to an [**environment**](#environment)
        //by creating a [**deployment**](#deployment)
        [Fact]
        public void When_Given_Deployment_Project_Has_Zero_Or_More_Environment_Ready_Releases()
        {

        }


        //test project has 0 or more releases


        //releases can be released to environment



        //Deployment must have an environment


        //Create an Environment

        //Create a release



    }
}
