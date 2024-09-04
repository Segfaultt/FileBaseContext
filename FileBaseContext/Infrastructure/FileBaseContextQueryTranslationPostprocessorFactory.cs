using Microsoft.EntityFrameworkCore.Query;

namespace FileBaseContext.Infrastructure;

public class FileBaseContextQueryTranslationPostprocessorFactory : IQueryTranslationPostprocessorFactory
{
    private readonly QueryTranslationPostprocessorDependencies _dependencies;

    public FileBaseContextQueryTranslationPostprocessorFactory(QueryTranslationPostprocessorDependencies dependencies)
    {
        _dependencies = dependencies;
    }

    public virtual QueryTranslationPostprocessor Create(QueryCompilationContext queryCompilationContext)
    {
        return new FileBaseContextQueryTranslationPostprocessor(_dependencies, queryCompilationContext);
    }
}