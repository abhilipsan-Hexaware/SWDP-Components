using Microsoft.Extensions.DependencyInjection;

namespace Tracing.Data.Installer
{
    public class DataInstaller
    {
        private IServiceCollection _service;
        public DataInstaller(IServiceCollection service)
        {
            _service = service;
        }

        public void Install()
        {
             _service.Scan(scan => scan
                                    .FromAssemblyOf<DataInstaller>()
                                    .AddClasses()
                                    .AsImplementedInterfaces()
                                    .WithScopedLifetime());
        }
    }
}
