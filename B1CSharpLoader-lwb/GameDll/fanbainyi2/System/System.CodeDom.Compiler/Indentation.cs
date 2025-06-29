using System.Text;

namespace System.CodeDom.Compiler;

internal class Indentation
{
	private IndentedTextWriter writer;

	private int indent;

	private string s;

	internal string IndentationString
	{
		get
		{
			if (s == null)
			{
				string tabString = writer.TabString;
				StringBuilder stringBuilder = new StringBuilder(indent * tabString.Length);
				for (int i = 0; i < indent; i++)
				{
					stringBuilder.Append(tabString);
				}
				s = stringBuilder.ToString();
			}
			return s;
		}
	}

	internal Indentation(IndentedTextWriter writer, int indent)
	{
		this.writer = writer;
		this.indent = indent;
		s = null;
	}
}
