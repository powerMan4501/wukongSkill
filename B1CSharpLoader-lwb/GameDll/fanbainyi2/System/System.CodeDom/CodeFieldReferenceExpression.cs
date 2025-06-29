using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeFieldReferenceExpression : CodeExpression
{
	private CodeExpression targetObject;

	private string fieldName;

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

	public string FieldName
	{
		get
		{
			if (fieldName != null)
			{
				return fieldName;
			}
			return string.Empty;
		}
		set
		{
			fieldName = value;
		}
	}

	public CodeFieldReferenceExpression()
	{
	}

	public CodeFieldReferenceExpression(CodeExpression targetObject, string fieldName)
	{
		TargetObject = targetObject;
		FieldName = fieldName;
	}
}
