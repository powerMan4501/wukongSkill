using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeSnippetTypeMember : CodeTypeMember
{
	private string text;

	public string Text
	{
		get
		{
			if (text != null)
			{
				return text;
			}
			return string.Empty;
		}
		set
		{
			text = value;
		}
	}

	public CodeSnippetTypeMember()
	{
	}

	public CodeSnippetTypeMember(string text)
	{
		Text = text;
	}
}
