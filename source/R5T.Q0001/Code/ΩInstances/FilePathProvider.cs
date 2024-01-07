using System;


namespace R5T.Q0001
{
	public class FilePathProvider : IFilePathProvider
	{
		#region Infrastructure

	    public static FilePathProvider Instance { get; } = new();

	    private FilePathProvider()
	    {
	    }

	    #endregion
	}
}