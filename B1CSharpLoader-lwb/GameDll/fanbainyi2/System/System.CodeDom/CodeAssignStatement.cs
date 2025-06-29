using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeAssignStatement : CodeStatement
{
	private CodeExpression left;

	private CodeExpression right;

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

	public CodeAssignStatement()
	{
	}

	public CodeAssignStatement(CodeExpression left, CodeExpression right)
	{
		Left = left;
		Right = right;
	}
}
