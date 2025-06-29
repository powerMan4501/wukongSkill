using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeObjectCreateExpression : CodeExpression
{
	private CodeTypeReference createType;

	private CodeExpressionCollection parameters = new CodeExpressionCollection();

	public CodeTypeReference CreateType
	{
		get
		{
			if (createType == null)
			{
				createType = new CodeTypeReference("");
			}
			return createType;
		}
		set
		{
			createType = value;
		}
	}

	public CodeExpressionCollection Parameters => parameters;

	public CodeObjectCreateExpression()
	{
	}

	public CodeObjectCreateExpression(CodeTypeReference createType, params CodeExpression[] parameters)
	{
		CreateType = createType;
		Parameters.AddRange(parameters);
	}

	public CodeObjectCreateExpression(string createType, params CodeExpression[] parameters)
	{
		CreateType = new CodeTypeReference(createType);
		Parameters.AddRange(parameters);
	}

	public CodeObjectCreateExpression(Type createType, params CodeExpression[] parameters)
	{
		CreateType = new CodeTypeReference(createType);
		Parameters.AddRange(parameters);
	}
}
