using System;

using R5T.F0006;
using R5T.F0007;
using R5T.F0008;

using ISyntaxGenerator = R5T.F0023.ISyntaxGenerator;
using ISyntaxGenerator_Simple = R5T.F0004.ISyntaxGenerator;


namespace R5T.Q0001
{
    public static class Instances
    {
        public static ICompilationUnitGenerator CompilationUnitGenerator { get; } = F0008.CompilationUnitGenerator.Instance;
        public static IFilePathProvider FilePathProvider { get; } = Q0001.FilePathProvider.Instance;
        public static IIndentationGenerator IndentationGenerator { get; } = F0007.IndentationGenerator.Instance;
        public static ISyntaxGenerator SyntaxGenerator { get; } = F0023.SyntaxGenerator.Instance;
        public static ISyntaxGenerator_Simple SyntaxGenerator_Simple { get; } = F0004.SyntaxGenerator.Instance;
        public static ISyntaxGenerationDemonstrations SyntaxGenerationDemonstrations { get; } = Q0001.SyntaxGenerationDemonstrations.Instance;
        public static ISyntaxGenerationExplorations SyntaxGenerationExplorations { get; } = Q0001.SyntaxGenerationExplorations.Instance;
        public static ISyntaxOperator SyntaxOperator { get; } = Q0001.SyntaxOperator.Instance;
        public static ISyntaxParser SyntaxParser { get; } = F0006.SyntaxParser.Instance;
    }
}
