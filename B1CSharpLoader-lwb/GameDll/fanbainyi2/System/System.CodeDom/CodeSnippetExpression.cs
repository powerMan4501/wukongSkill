using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeSnippetExpression : CodeExpression
{
	private string value;

	public string Value
	{
		get
		{
			if (value != null)
			{
				return value;
			}
			return string.Empty;
		}
		set
		{
			this.value = value;
		}
	}

	public CodeSnippetExpression()
	{
	}

	public CodeSnippetExpression(string value)
	{
		Value = value;
	}
}
