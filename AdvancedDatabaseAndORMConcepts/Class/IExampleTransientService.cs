using Microsoft.Extensions.DependencyInjection;

namespace AdvancedDatabaseAndORMConcepts.Class
{
    public interface IExampleTransientService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
    }
}
