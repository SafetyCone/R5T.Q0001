using System;

using R5T.T0132;


namespace R5T.Q0001
{
	[FunctionalityMarker]
	public interface IFilePathProvider : IFunctionalityMarker
	{
		public string GetOutputFilePath(
			string fileName)
        {
			var output = $@"C:\Temp\{fileName}";
			return output;
        }
	}
}