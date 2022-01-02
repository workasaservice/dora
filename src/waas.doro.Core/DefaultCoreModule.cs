using Autofac;
using waas.doro.Core.Interfaces;
using waas.doro.Core.Services;

namespace waas.doro.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
