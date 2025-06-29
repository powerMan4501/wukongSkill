using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeExpressionStatement : CodeStatement
{
	private CodeExpression expression;

	public CodeExpression Expression
	{
		get
		{
			return expression;
		}
		set
		{
			expression = value;
		}
	}

	public CodeExpressionStatement()
	{
	}

	public CodeExpressionStatement(CodeExpression expression)
	{
		this.expression = expression;
	}
}
