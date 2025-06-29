using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeLabeledStatement : CodeStatement
{
	private string label;

	private CodeStatement statement;

	public string Label
	{
		get
		{
			if (label != null)
			{
				return label;
			}
			return string.Empty;
		}
		set
		{
			label = value;
		}
	}

	public CodeStatement Statement
	{
		get
		{
			return statement;
		}
		set
		{
			statement = value;
		}
	}

	public CodeLabeledStatement()
	{
	}

	public CodeLabeledStatement(string label)
	{
		this.label = label;
	}

	public CodeLabeledStatement(string label, CodeStatement statement)
	{
		this.label = label;
		this.statement = statement;
	}
}
