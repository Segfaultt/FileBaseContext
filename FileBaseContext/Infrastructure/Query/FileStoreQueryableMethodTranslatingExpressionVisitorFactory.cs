using Microsoft.EntityFrameworkCore.Query;

namespace FileBaseContext.Infrastructure.Query;

public class FileBaseContextQueryableMethodTranslatingExpressionVisitorFactory : IQueryableMethodTranslatingExpressionVisitorFactory
{
    public FileBaseContextQueryableMethodTranslatingExpressionVisitorFactory(
        QueryableMethodTranslatingExpressionVisitorDependencies dependencies)
    {
        Dependencies = dependencies;
    }

    protected virtual QueryableMethodTranslatingExpressionVisitorDependencies Dependencies { get; }

    public virtual QueryableMethodTranslatingExpressionVisitor Create(QueryCompilationContext queryCompilationContext)
        => new FileBaseContextQueryableMethodTranslatingExpressionVisitor(Dependencies, queryCompilationContext);
}