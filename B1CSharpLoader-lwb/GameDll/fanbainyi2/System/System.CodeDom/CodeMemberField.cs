using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeMemberField : CodeTypeMember
{
	private CodeTypeReference type;

	private CodeExpression initExpression;

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

	public CodeExpression InitExpression
	{
		get
		{
			return initExpression;
		}
		set
		{
			initExpression = value;
		}
	}

	public CodeMemberField()
	{
	}

	public CodeMemberField(CodeTypeReference type, string name)
	{
		Type = type;
		base.Name = name;
	}

	public CodeMemberField(string type, string name)
	{
		Type = new CodeTypeReference(type);
		base.Name = name;
	}

	public CodeMemberField(Type type, string name)
	{
		Type = new CodeTypeReference(type);
		base.Name = name;
	}
}
