
using Microsoft.Extensions.DependencyInjection;
namespace AdvancedDatabaseAndORMConcepts.Class
{
    public interface IReportServiceLifetime
    {
        Guid Id { get; }

        ServiceLifetime Lifetime { get; }
    }
}
