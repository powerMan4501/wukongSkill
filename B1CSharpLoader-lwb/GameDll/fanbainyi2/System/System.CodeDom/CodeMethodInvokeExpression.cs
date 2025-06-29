using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeMethodInvokeExpression : CodeExpression
{
	private CodeMethodReferenceExpression method;

	private CodeExpressionCollection parameters = new CodeExpressionCollection();

	public CodeMethodReferenceExpression Method
	{
		get
		{
			if (method == null)
			{
				method = new CodeMethodReferenceExpression();
			}
			return method;
		}
		set
		{
			method = value;
		}
	}

	public CodeExpressionCollection Parameters => parameters;

	public CodeMethodInvokeExpression()
	{
	}

	public CodeMethodInvokeExpression(CodeMethodReferenceExpression method, params CodeExpression[] parameters)
	{
		this.method = method;
		Parameters.AddRange(parameters);
	}

	public CodeMethodInvokeExpression(CodeExpression targetObject, string methodName, params CodeExpression[] parameters)
	{
		method = new CodeMethodReferenceExpression(targetObject, methodName);
		Parameters.AddRange(parameters);
	}
}
