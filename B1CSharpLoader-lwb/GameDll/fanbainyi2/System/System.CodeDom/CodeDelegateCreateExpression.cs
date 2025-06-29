using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeDelegateCreateExpression : CodeExpression
{
	private CodeTypeReference delegateType;

	private CodeExpression targetObject;

	private string methodName;

	public CodeTypeReference DelegateType
	{
		get
		{
			if (delegateType == null)
			{
				delegateType = new CodeTypeReference("");
			}
			return delegateType;
		}
		set
		{
			delegateType = value;
		}
	}

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

	public string MethodName
	{
		get
		{
			if (methodName != null)
			{
				return methodName;
			}
			return string.Empty;
		}
		set
		{
			methodName = value;
		}
	}

	public CodeDelegateCreateExpression()
	{
	}

	public CodeDelegateCreateExpression(CodeTypeReference delegateType, CodeExpression targetObject, string methodName)
	{
		this.delegateType = delegateType;
		this.targetObject = targetObject;
		this.methodName = methodName;
	}
}
