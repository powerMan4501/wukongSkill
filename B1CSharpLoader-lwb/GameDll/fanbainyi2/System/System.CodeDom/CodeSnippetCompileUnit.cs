using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeSnippetCompileUnit : CodeCompileUnit
{
	private string value;

	private CodeLinePragma linePragma;

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

	public CodeLinePragma LinePragma
	{
		get
		{
			return linePragma;
		}
		set
		{
			linePragma = value;
		}
	}

	public CodeSnippetCompileUnit()
	{
	}

	public CodeSnippetCompileUnit(string value)
	{
		Value = value;
	}
}
