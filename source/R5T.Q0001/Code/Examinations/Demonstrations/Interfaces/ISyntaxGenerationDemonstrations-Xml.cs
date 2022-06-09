using System;

using R5T.Magyar.Extensions;

using R5T.T0141;


namespace R5T.Q0001
{
	public partial interface ISyntaxGenerationDemonstrations
	{
        public void XmlSummaryElementOnly()
        {
            var codeFileName = "XmlSummary.cs";

            var xmlSummary = Instances.SyntaxGenerator.XmlSummaryElementOnly();

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                xmlSummary,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        public void XmlTextLiteral()
        {
            var codeFileName = "XmlTextLiteral.cs";

            var xml = Instances.SyntaxGenerator.XmlTextLiteral("Hello world!");

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                xml,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }
    }
}