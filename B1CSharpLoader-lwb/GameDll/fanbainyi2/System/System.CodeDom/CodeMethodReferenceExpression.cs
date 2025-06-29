using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeMethodReferenceExpression : CodeExpression
{
	private CodeExpression targetObject;

	private string methodName;

	[OptionalField]
	private CodeTypeReferenceCollection typeArguments;

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

	[ComVisible(false)]
	public CodeTypeReferenceCollection TypeArguments
	{
		get
		{
			if (typeArguments == null)
			{
				typeArguments = new CodeTypeReferenceCollection();
			}
			return typeArguments;
		}
	}

	public CodeMethodReferenceExpression()
	{
	}

	public CodeMethodReferenceExpression(CodeExpression targetObject, string methodName)
	{
		TargetObject = targetObject;
		MethodName = methodName;
	}

	public CodeMethodReferenceExpression(CodeExpression targetObject, string methodName, params CodeTypeReference[] typeParameters)
	{
		TargetObject = targetObject;
		MethodName = methodName;
		if (typeParameters != null && typeParameters.Length != 0)
		{
			TypeArguments.AddRange(typeParameters);
		}
	}
}
