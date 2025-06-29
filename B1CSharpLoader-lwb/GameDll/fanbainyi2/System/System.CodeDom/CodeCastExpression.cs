using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeCastExpression : CodeExpression
{
	private CodeTypeReference targetType;

	private CodeExpression expression;

	public CodeTypeReference TargetType
	{
		get
		{
			if (targetType == null)
			{
				targetType = new CodeTypeReference("");
			}
			return targetType;
		}
		set
		{
			targetType = value;
		}
	}

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

	public CodeCastExpression()
	{
	}

	public CodeCastExpression(CodeTypeReference targetType, CodeExpression expression)
	{
		TargetType = targetType;
		Expression = expression;
	}

	public CodeCastExpression(string targetType, CodeExpression expression)
	{
		TargetType = new CodeTypeReference(targetType);
		Expression = expression;
	}

	public CodeCastExpression(Type targetType, CodeExpression expression)
	{
		TargetType = new CodeTypeReference(targetType);
		Expression = expression;
	}
}
