using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeBinaryOperatorExpression : CodeExpression
{
	private CodeBinaryOperatorType op;

	private CodeExpression left;

	private CodeExpression right;

	public CodeExpression Right
	{
		get
		{
			return right;
		}
		set
		{
			right = value;
		}
	}

	public CodeExpression Left
	{
		get
		{
			return left;
		}
		set
		{
			left = value;
		}
	}

	public CodeBinaryOperatorType Operator
	{
		get
		{
			return op;
		}
		set
		{
			op = value;
		}
	}

	public CodeBinaryOperatorExpression()
	{
	}

	public CodeBinaryOperatorExpression(CodeExpression left, CodeBinaryOperatorType op, CodeExpression right)
	{
		Right = right;
		Operator = op;
		Left = left;
	}
}
