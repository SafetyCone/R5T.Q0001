using System;

using R5T.Magyar.Extensions;

using R5T.T0141;


namespace R5T.Q0001
{
	public partial interface ISyntaxGenerationDemonstrations
	{
        public void Documentation01()
        {
            var documentationLine = "Common generation, initial, parse, text sourcing, text constants for Roslyn syntax elements.";
            var documentationText =
$@"
/// <summary>
/// {documentationLine}
/// </summary>
";
            var documentation = Instances.SyntaxParser.ParseDocumentation(documentationText);

            var codeFileName = "Documentation01.cs";

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                documentation,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        public void Documentation02()
        {
            var summaryText = "Common generation, initial, parse, text sourcing, text constants for Roslyn syntax elements.";

            var documentation = Instances.SyntaxGenerator.GetSummaryDocumentationCommentSyntax(summaryText);

            var codeFileName = "Documentation02.cs";

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                documentation,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }
    }
}