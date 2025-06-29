using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodePropertyReferenceExpression : CodeExpression
{
	private CodeExpression targetObject;

	private string propertyName;

	private CodeExpressionCollection parameters = new CodeExpressionCollection();

	public CodeExpression TargetObject
	{
		get
		{
			return targetObject;
		}
		set
		{
			targetObject = value;
		}
	}

	public string PropertyName
	{
		get
		{
			if (propertyName != null)
			{
				return propertyName;
			}
			return string.Empty;
		}
		set
		{
			propertyName = value;
		}
	}

	public CodePropertyReferenceExpression()
	{
	}

	public CodePropertyReferenceExpression(CodeExpression targetObject, string propertyName)
	{
		TargetObject = targetObject;
		PropertyName = propertyName;
	}
}
