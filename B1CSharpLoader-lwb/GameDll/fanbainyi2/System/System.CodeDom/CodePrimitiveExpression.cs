using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodePrimitiveExpression : CodeExpression
{
	private object value;

	public object Value
	{
		get
		{
			return value;
		}
		set
		{
			this.value = value;
		}
	}

	public CodePrimitiveExpression()
	{
	}

	public CodePrimitiveExpression(object value)
	{
		Value = value;
	}
}
