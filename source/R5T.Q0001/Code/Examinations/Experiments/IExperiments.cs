using System;

using Microsoft.CodeAnalysis.CSharp;

using R5T.T0141;


namespace R5T.Q0001
{
    [ExperimentsMarker]
    public partial interface IExperiments : IExperimentsMarker
    {
        /// <summary>
        /// Is it possible, at runtime, to determine what language version is supported, or what version of the compiler you are using?
        /// Something like "Microsoft.CodeAnalysis.Version.Current"?
        /// <para>
        /// Result: NO!
        /// But it is possible to specify a language version to use for parsing a piece of code, and testing the values available in the <see cref="LanguageVersion"/> enumeration can help.
        /// </para>
        /// </summary>
        public void Get_CSharpLanguageVersionForRoslyn()
        {
            // Useful at compile time in VS:
            //#error version

            /// It *is* possible to specify a language version for use in parsing some code.
            //CSharpParseOptions a;

            //var syntaxTree = SyntaxFactory.SyntaxTree(, );

            /// And then ask for the language version of piece of parsed syntax:
            //(syntaxTree.Options as CSharpParseOptions).LanguageVersion

            /// Can test the values of the 
        }
    }
}
