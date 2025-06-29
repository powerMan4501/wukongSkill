using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeCommentStatement : CodeStatement
{
	private CodeComment comment;

	public CodeComment Comment
	{
		get
		{
			return comment;
		}
		set
		{
			comment = value;
		}
	}

	public CodeCommentStatement()
	{
	}

	public CodeCommentStatement(CodeComment comment)
	{
		this.comment = comment;
	}

	public CodeCommentStatement(string text)
	{
		comment = new CodeComment(text);
	}

	public CodeCommentStatement(string text, bool docComment)
	{
		comment = new CodeComment(text, docComment);
	}
}
