using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeIterationStatement : CodeStatement
{
	private CodeStatement initStatement;

	private CodeExpression testExpression;

	private CodeStatement incrementStatement;

	private CodeStatementCollection statements = new CodeStatementCollection();

	public CodeStatement InitStatement
	{
		get
		{
			return initStatement;
		}
		set
		{
			initStatement = value;
		}
	}

	public CodeExpression TestExpression
	{
		get
		{
			return testExpression;
		}
		set
		{
			testExpression = value;
		}
	}

	public CodeStatement IncrementStatement
	{
		get
		{
			return incrementStatement;
		}
		set
		{
			incrementStatement = value;
		}
	}

	public CodeStatementCollection Statements => statements;

	public CodeIterationStatement()
	{
	}

	public CodeIterationStatement(CodeStatement initStatement, CodeExpression testExpression, CodeStatement incrementStatement, params CodeStatement[] statements)
	{
		InitStatement = initStatement;
		TestExpression = testExpression;
		IncrementStatement = incrementStatement;
		Statements.AddRange(statements);
	}
}
