using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeTypeReferenceExpression : CodeExpression
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

	public CodeTypeReferenceExpression()
	{
	}

	public CodeTypeReferenceExpression(CodeTypeReference type)
	{
		Type = type;
	}

	public CodeTypeReferenceExpression(string type)
	{
		Type = new CodeTypeReference(type);
	}

	public CodeTypeReferenceExpression(Type type)
	{
		Type = new CodeTypeReference(type);
	}
}
