using System;


namespace R5T.Q0001
{
	public class SyntaxOperator : ISyntaxOperator
	{
		#region Infrastructure

	    public static SyntaxOperator Instance { get; } = new();

	    private SyntaxOperator()
	    {
	    }

	    #endregion
	}
}