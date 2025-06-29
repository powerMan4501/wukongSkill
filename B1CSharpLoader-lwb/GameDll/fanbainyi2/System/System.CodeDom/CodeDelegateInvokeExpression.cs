using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeDelegateInvokeExpression : CodeExpression
{
	private CodeExpression targetObject;

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

	public CodeExpressionCollection Parameters => parameters;

	public CodeDelegateInvokeExpression()
	{
	}

	public CodeDelegateInvokeExpression(CodeExpression targetObject)
	{
		TargetObject = targetObject;
	}

	public CodeDelegateInvokeExpression(CodeExpression targetObject, params CodeExpression[] parameters)
	{
		TargetObject = targetObject;
		Parameters.AddRange(parameters);
	}
}
