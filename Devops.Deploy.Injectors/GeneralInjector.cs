using Devops.Deploy.Interfaces;
using Devops.Deploy.Objects;
using Devops.Deploy.Services;
using Ninject.Modules;

namespace Devops.Deploy.Injectors
{
    public class GeneralInjector : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IReleaseService>().To<ReleaseService>();
            this.Bind<IRelease>().To<Release>();

            this.Bind<IProjectService>().To<ProjectService>();
            this.Bind<IProject>().To<Project>();
        }
    }
}
