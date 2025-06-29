using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeAttributeArgument
{
	private string name;

	private CodeExpression value;

	public string Name
	{
		get
		{
			if (name != null)
			{
				return name;
			}
			return string.Empty;
		}
		set
		{
			name = value;
		}
	}

	public CodeExpression Value
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

	public CodeAttributeArgument()
	{
	}

	public CodeAttributeArgument(CodeExpression value)
	{
		Value = value;
	}

	public CodeAttributeArgument(string name, CodeExpression value)
	{
		Name = name;
		Value = value;
	}
}
