using System.Reflection;
using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeTypeDelegate : CodeTypeDeclaration
{
	private CodeParameterDeclarationExpressionCollection parameters = new CodeParameterDeclarationExpressionCollection();

	private CodeTypeReference returnType;

	public CodeTypeReference ReturnType
	{
		get
		{
			if (returnType == null)
			{
				returnType = new CodeTypeReference("");
			}
			return returnType;
		}
		set
		{
			returnType = value;
		}
	}

	public CodeParameterDeclarationExpressionCollection Parameters => parameters;

	public CodeTypeDelegate()
	{
		base.TypeAttributes &= ~TypeAttributes.ClassSemanticsMask;
		base.TypeAttributes |= TypeAttributes.NotPublic;
		base.BaseTypes.Clear();
		base.BaseTypes.Add(new CodeTypeReference("System.Delegate"));
	}

	public CodeTypeDelegate(string name)
		: this()
	{
		base.Name = name;
	}
}
