using Microsoft.Extensions.DependencyInjection;

namespace AdvancedDatabaseAndORMConcepts.Class
{
    public interface IExampleScopedService: IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
    }
}
