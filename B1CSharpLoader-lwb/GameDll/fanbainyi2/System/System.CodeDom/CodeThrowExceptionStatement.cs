using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeThrowExceptionStatement : CodeStatement
{
	private CodeExpression toThrow;

	public CodeExpression ToThrow
	{
		get
		{
			return toThrow;
		}
		set
		{
			toThrow = value;
		}
	}

	public CodeThrowExceptionStatement()
	{
	}

	public CodeThrowExceptionStatement(CodeExpression toThrow)
	{
		ToThrow = toThrow;
	}
}
