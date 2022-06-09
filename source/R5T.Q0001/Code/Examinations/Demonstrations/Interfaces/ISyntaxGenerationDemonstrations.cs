using System;

using R5T.Magyar.Extensions;

using R5T.T0141;


namespace R5T.Q0001
{
	[DemonstrationsMarker]
	public partial interface ISyntaxGenerationDemonstrations : IDemonstrationsMarker
	{
        /// <summary>
        /// Generates a class.
        /// </summary>
        public void Class()
        {
            var className = "Class1";
            var codeFileName = "Class1.cs";

            var @class = Instances.SyntaxGenerator.Class(className);

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                @class,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        public void ClassCompilationUnit()
        {
            var namespaceName = "Namespace1";
            var className = "Class1";
            var codeFileName = "Class-CompilationUnit.cs";

            var @class = Instances.CompilationUnitGenerator.CreatePublicClass(
                namespaceName,
                className,
                out _);

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                @class,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        /// <summary>
        /// Generates the class produced by initial simple generation (direct from the Roslyn syntax factory).
        /// Note: there is spacing between tokens.
        /// </summary>
        public void Class_Initial_Simple()
        {
            var className = "Class1";
            var codeFileName = "Class1-Initial-Simple.cs";

            var @class = Instances.SyntaxGenerator_Simple.Class(className);

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                @class,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        public void Class_Parse_Simple_WithRegion()
        {
            var classTypeName = "Class1";
            var baseInterfaceTypeName = "Interface1";

            // Parse-simple will not trim extra new lines.
            var @class = Instances.SyntaxParser.As<F0005.ISyntaxParser>().ParseClass(
// Note the extra new lines.
$@"
public class {classTypeName} : {baseInterfaceTypeName}
{{
    #region Infrastructure

    public static {classTypeName} Instance {{ get; }} = new();

    private {classTypeName}()
    {{
    }}

    #endregion
}}
");

            var codeFileName = "Class1-Parse-Simple.cs";

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                @class,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        public void Class_Parse_WithRegion()
        {
            var classTypeName = "Class1";
            var baseInterfaceTypeName = "Interface1";

            // Parse will trim the extra new lines.
            var @class = Instances.SyntaxParser.ParseClass(
// Note the extra new lines.
$@"
public class {classTypeName} : {baseInterfaceTypeName}
{{
    #region Infrastructure

    public static {classTypeName} Instance {{ get; }} = new();

    private {classTypeName}()
    {{
    }}

    #endregion
}}
");

            var codeFileName = "Class1-Parse.cs";

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                @class,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        public void ClassPublicStatic()
        {
            var namespaceName = "Namespace1";
            var className = "Class1";
            var codeFileName = "Class-Public-Static.cs";

            var @class = Instances.CompilationUnitGenerator.CreatePublicStaticClass(
                namespaceName,
                className,
                out _);

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                @class,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        public void Class100()
        {
            var namespaceName = "Namespace01";
            var classTypeName = "Class100";
            var baseInterfaceTypeName = "Interface1";

            var @class = Instances.SyntaxParser.ParseClass(
$@"public class {classTypeName} : {baseInterfaceTypeName}
{{
    #region Infrastructure

    public static {classTypeName} Instance {{ get; }} = new();

    private {classTypeName}()
    {{
    }}

    #endregion
}}");
            @class = @class
                .PrependNewLine()
                .Indent(
                    Instances.IndentationGenerator.ForClass());

            var compilationUnit = Instances.CompilationUnitGenerator.CreateNamespace(
                namespaceName,
                out var namespaceAnnotation);

            compilationUnit = namespaceAnnotation.AddMember(
                compilationUnit,
                @class);

            var codeFileName = "Class100.cs";

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                compilationUnit,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        public void Class101()
        {
            var classTypeName = "Class100";
            var baseInterfaceTypeName = "Interface1";

            var @class = Instances.SyntaxParser.ParseClass(
$@"public class {classTypeName} : {baseInterfaceTypeName}
{{
    #region Infrastructure

    public static {classTypeName} Instance {{ get; }} = new();

    private {classTypeName}()
    {{
    }}

    #endregion
}}");

            @class = @class
                .Indent(
                    Instances.IndentationGenerator.ForClass());

            var codeFileName = "Class101.cs";

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                @class,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        public void CompilationUnit()
        {
            var codeFileName = "CompilationUnit.cs";

            var compilationUnit = Instances.SyntaxGenerator_Simple.CompilationUnit();

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                compilationUnit,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        public void Namespace()
        {
            var namespaceName = "Namespace1";
            var codeFileName = "Namespace1.cs";

            var @class = Instances.SyntaxGenerator.Namespace(namespaceName);

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                @class,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }

        public void Namespace_Initial_Simple()
        {
            var namespaceName = "Namespace1";
            var codeFileName = "Namespace1-Initial-Simple.cs";

            var @class = Instances.SyntaxGenerator_Simple.Namespace(namespaceName);

            Instances.SyntaxOperator.WriteToFile_Synchronous(
                @class,
                Instances.FilePathProvider.GetOutputFilePath(codeFileName));
        }
    }
}