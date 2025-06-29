using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeTypeParameter : CodeObject
{
	private string name;

	private CodeAttributeDeclarationCollection customAttributes;

	private CodeTypeReferenceCollection constraints;

	private bool hasConstructorConstraint;

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

	public CodeTypeReferenceCollection Constraints
	{
		get
		{
			if (constraints == null)
			{
				constraints = new CodeTypeReferenceCollection();
			}
			return constraints;
		}
	}

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
	}

	public bool HasConstructorConstraint
	{
		get
		{
			return hasConstructorConstraint;
		}
		set
		{
			hasConstructorConstraint = value;
		}
	}

	public CodeTypeParameter()
	{
	}

	public CodeTypeParameter(string name)
	{
		this.name = name;
	}
}
