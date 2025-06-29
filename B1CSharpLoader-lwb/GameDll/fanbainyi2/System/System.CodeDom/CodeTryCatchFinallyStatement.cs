using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeTryCatchFinallyStatement : CodeStatement
{
	private CodeStatementCollection tryStatments = new CodeStatementCollection();

	private CodeStatementCollection finallyStatments = new CodeStatementCollection();

	private CodeCatchClauseCollection catchClauses = new CodeCatchClauseCollection();

	public CodeStatementCollection TryStatements => tryStatments;

	public CodeCatchClauseCollection CatchClauses => catchClauses;

	public CodeStatementCollection FinallyStatements => finallyStatments;

	public CodeTryCatchFinallyStatement()
	{
	}

	public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses)
	{
		TryStatements.AddRange(tryStatements);
		CatchClauses.AddRange(catchClauses);
	}

	public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses, CodeStatement[] finallyStatements)
	{
		TryStatements.AddRange(tryStatements);
		CatchClauses.AddRange(catchClauses);
		FinallyStatements.AddRange(finallyStatements);
	}
}
