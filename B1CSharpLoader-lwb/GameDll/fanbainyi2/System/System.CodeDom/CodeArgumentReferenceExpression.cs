using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeArgumentReferenceExpression : CodeExpression
{
	private string parameterName;

	public string ParameterName
	{
		get
		{
			if (parameterName != null)
			{
				return parameterName;
			}
			return string.Empty;
		}
		set
		{
			parameterName = value;
		}
	}

	public CodeArgumentReferenceExpression()
	{
	}

	public CodeArgumentReferenceExpression(string parameterName)
	{
		this.parameterName = parameterName;
	}
}
