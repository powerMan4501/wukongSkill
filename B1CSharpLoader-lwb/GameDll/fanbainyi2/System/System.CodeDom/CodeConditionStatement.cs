using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeConditionStatement : CodeStatement
{
	private CodeExpression condition;

	private CodeStatementCollection trueStatments = new CodeStatementCollection();

	private CodeStatementCollection falseStatments = new CodeStatementCollection();

	public CodeExpression Condition
	{
		get
		{
			return condition;
		}
		set
		{
			condition = value;
		}
	}

	public CodeStatementCollection TrueStatements => trueStatments;

	public CodeStatementCollection FalseStatements => falseStatments;

	public CodeConditionStatement()
	{
	}

	public CodeConditionStatement(CodeExpression condition, params CodeStatement[] trueStatements)
	{
		Condition = condition;
		TrueStatements.AddRange(trueStatements);
	}

	public CodeConditionStatement(CodeExpression condition, CodeStatement[] trueStatements, CodeStatement[] falseStatements)
	{
		Condition = condition;
		TrueStatements.AddRange(trueStatements);
		FalseStatements.AddRange(falseStatements);
	}
}
