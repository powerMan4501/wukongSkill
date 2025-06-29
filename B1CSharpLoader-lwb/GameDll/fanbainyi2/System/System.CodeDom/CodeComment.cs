using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeComment : CodeObject
{
	private string text;

	private bool docComment;

	public bool DocComment
	{
		get
		{
			return docComment;
		}
		set
		{
			docComment = value;
		}
	}

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

	public CodeComment()
	{
	}

	public CodeComment(string text)
	{
		Text = text;
	}

	public CodeComment(string text, bool docComment)
	{
		Text = text;
		this.docComment = docComment;
	}
}
