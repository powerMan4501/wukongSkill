using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeGotoStatement : CodeStatement
{
	private string label;

	public string Label
	{
		get
		{
			return label;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentNullException("value");
			}
			label = value;
		}
	}

	public CodeGotoStatement()
	{
	}

	public CodeGotoStatement(string label)
	{
		Label = label;
	}
}
