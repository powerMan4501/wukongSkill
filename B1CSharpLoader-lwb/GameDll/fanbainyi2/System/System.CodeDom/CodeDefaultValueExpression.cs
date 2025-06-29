using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeDefaultValueExpression : CodeExpression
{
	private CodeTypeReference type;

	public CodeTypeReference Type
	{
		get
		{
			if (type == null)
			{
				type = new CodeTypeReference("");
			}
			return type;
		}
		set
		{
			type = value;
		}
	}

	public CodeDefaultValueExpression()
	{
	}

	public CodeDefaultValueExpression(CodeTypeReference type)
	{
		this.type = type;
	}
}
