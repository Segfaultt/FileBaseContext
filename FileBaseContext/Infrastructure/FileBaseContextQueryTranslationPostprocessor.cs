using Microsoft.EntityFrameworkCore.Query;

namespace FileBaseContext.Infrastructure;

public class FileBaseContextQueryTranslationPostprocessor : QueryTranslationPostprocessor
{
    public FileBaseContextQueryTranslationPostprocessor(
        QueryTranslationPostprocessorDependencies dependencies,
        QueryCompilationContext queryCompilationContext)
        : base(dependencies, queryCompilationContext)
    {
    }
}