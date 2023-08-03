using Microsoft.Extensions.DependencyInjection;

namespace AdvancedDatabaseAndORMConcepts.Class
{
    public interface IExampleSingletonService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
    }
}
