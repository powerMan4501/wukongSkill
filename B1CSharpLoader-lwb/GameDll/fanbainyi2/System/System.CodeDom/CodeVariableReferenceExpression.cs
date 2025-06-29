using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeVariableReferenceExpression : CodeExpression
{
	private string variableName;

	public string VariableName
	{
		get
		{
			if (variableName != null)
			{
				return variableName;
			}
			return string.Empty;
		}
		set
		{
			variableName = value;
		}
	}

	public CodeVariableReferenceExpression()
	{
	}

	public CodeVariableReferenceExpression(string variableName)
	{
		this.variableName = variableName;
	}
}
