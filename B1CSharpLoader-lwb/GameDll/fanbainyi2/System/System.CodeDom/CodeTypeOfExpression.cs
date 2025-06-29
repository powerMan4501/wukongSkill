using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeTypeOfExpression : CodeExpression
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

	public CodeTypeOfExpression()
	{
	}

	public CodeTypeOfExpression(CodeTypeReference type)
	{
		Type = type;
	}

	public CodeTypeOfExpression(string type)
	{
		Type = new CodeTypeReference(type);
	}

	public CodeTypeOfExpression(Type type)
	{
		Type = new CodeTypeReference(type);
	}
}
