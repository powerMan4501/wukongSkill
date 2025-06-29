using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeParameterDeclarationExpression : CodeExpression
{
	private CodeTypeReference type;

	private string name;

	private CodeAttributeDeclarationCollection customAttributes;

	private FieldDirection dir;

	public CodeAttributeDeclarationCollection CustomAttributes
	{
		get
		{
			if (customAttributes == null)
			{
				customAttributes = new CodeAttributeDeclarationCollection();
			}
			return customAttributes;
		}
		set
		{
			customAttributes = value;
		}
	}

	public FieldDirection Direction
	{
		get
		{
			return dir;
		}
		set
		{
			dir = value;
		}
	}

	public CodeTypeReference Type
	{
		get
		{
			if (type == null)
			{
				type = new CodeTypeReference("");
			}
			return type;
		}
		set
		{
			type = value;
		}
	}

	public string Name
	{
		get
		{
			if (name != null)
			{
				return name;
			}
			return string.Empty;
		}
		set
		{
			name = value;
		}
	}

	public CodeParameterDeclarationExpression()
	{
	}

	public CodeParameterDeclarationExpression(CodeTypeReference type, string name)
	{
		Type = type;
		Name = name;
	}

	public CodeParameterDeclarationExpression(string type, string name)
	{
		Type = new CodeTypeReference(type);
		Name = name;
	}

	public CodeParameterDeclarationExpression(Type type, string name)
	{
		Type = new CodeTypeReference(type);
		Name = name;
	}
}
