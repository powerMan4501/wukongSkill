using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeAttributeDeclaration
{
	private string name;

	private CodeAttributeArgumentCollection arguments = new CodeAttributeArgumentCollection();

	[OptionalField]
	private CodeTypeReference attributeType;

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
			attributeType = new CodeTypeReference(name);
		}
	}

	public CodeAttributeArgumentCollection Arguments => arguments;

	public CodeTypeReference AttributeType => attributeType;

	public CodeAttributeDeclaration()
	{
	}

	public CodeAttributeDeclaration(string name)
	{
		Name = name;
	}

	public CodeAttributeDeclaration(string name, params CodeAttributeArgument[] arguments)
	{
		Name = name;
		Arguments.AddRange(arguments);
	}

	public CodeAttributeDeclaration(CodeTypeReference attributeType)
		: this(attributeType, (CodeAttributeArgument[])null)
	{
	}

	public CodeAttributeDeclaration(CodeTypeReference attributeType, params CodeAttributeArgument[] arguments)
	{
		this.attributeType = attributeType;
		if (attributeType != null)
		{
			name = attributeType.BaseType;
		}
		if (arguments != null)
		{
			Arguments.AddRange(arguments);
		}
	}
}
