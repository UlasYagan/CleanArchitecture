using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace Sum.Persistence.Interceptors;

public class SlowQueryInterceptor : DbCommandInterceptor
{
    private const int slowQueryThreshold = 200;

    public override DbDataReader ReaderExecuted(DbCommand command, CommandExecutedEventData eventData, DbDataReader result)
    {
        if (eventData.Duration.TotalMilliseconds > slowQueryThreshold)
        {
            Console.WriteLine($"Slow query ({eventData.Duration.TotalMilliseconds} ms): {command.CommandText}");
        }
        return base.ReaderExecuted(command, eventData, result);
    }
}
