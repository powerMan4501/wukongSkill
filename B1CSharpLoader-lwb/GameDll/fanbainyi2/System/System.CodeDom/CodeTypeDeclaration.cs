using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeTypeDeclaration : CodeTypeMember
{
	private TypeAttributes attributes = TypeAttributes.Public;

	private CodeTypeReferenceCollection baseTypes = new CodeTypeReferenceCollection();

	private CodeTypeMemberCollection members = new CodeTypeMemberCollection();

	private bool isEnum;

	private bool isStruct;

	private int populated;

	private const int BaseTypesCollection = 1;

	private const int MembersCollection = 2;

	[OptionalField]
	private CodeTypeParameterCollection typeParameters;

	[OptionalField]
	private bool isPartial;

	public TypeAttributes TypeAttributes
	{
		get
		{
			return attributes;
		}
		set
		{
			attributes = value;
		}
	}

	public CodeTypeReferenceCollection BaseTypes
	{
		get
		{
			if ((populated & 1) == 0)
			{
				populated |= 1;
				if (this.PopulateBaseTypes != null)
				{
					this.PopulateBaseTypes(this, EventArgs.Empty);
				}
			}
			return baseTypes;
		}
	}

	public bool IsClass
	{
		get
		{
			if ((attributes & TypeAttributes.ClassSemanticsMask) == 0 && !isEnum)
			{
				return !isStruct;
			}
			return false;
		}
		set
		{
			if (value)
			{
				attributes &= ~TypeAttributes.ClassSemanticsMask;
				attributes |= TypeAttributes.NotPublic;
				isStruct = false;
				isEnum = false;
			}
		}
	}

	public bool IsStruct
	{
		get
		{
			return isStruct;
		}
		set
		{
			if (value)
			{
				attributes &= ~TypeAttributes.ClassSemanticsMask;
				isStruct = true;
				isEnum = false;
			}
			else
			{
				isStruct = false;
			}
		}
	}

	public bool IsEnum
	{
		get
		{
			return isEnum;
		}
		set
		{
			if (value)
			{
				attributes &= ~TypeAttributes.ClassSemanticsMask;
				isStruct = false;
				isEnum = true;
			}
			else
			{
				isEnum = false;
			}
		}
	}

	public bool IsInterface
	{
		get
		{
			return (attributes & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask;
		}
		set
		{
			if (value)
			{
				attributes &= ~TypeAttributes.ClassSemanticsMask;
				attributes |= TypeAttributes.ClassSemanticsMask;
				isStruct = false;
				isEnum = false;
			}
			else
			{
				attributes &= ~TypeAttributes.ClassSemanticsMask;
			}
		}
	}

	public bool IsPartial
	{
		get
		{
			return isPartial;
		}
		set
		{
			isPartial = value;
		}
	}

	public CodeTypeMemberCollection Members
	{
		get
		{
			if ((populated & 2) == 0)
			{
				populated |= 2;
				if (this.PopulateMembers != null)
				{
					this.PopulateMembers(this, EventArgs.Empty);
				}
			}
			return members;
		}
	}

	[ComVisible(false)]
	public CodeTypeParameterCollection TypeParameters
	{
		get
		{
			if (typeParameters == null)
			{
				typeParameters = new CodeTypeParameterCollection();
			}
			return typeParameters;
		}
	}

	public event EventHandler PopulateBaseTypes;

	public event EventHandler PopulateMembers;

	public CodeTypeDeclaration()
	{
	}

	public CodeTypeDeclaration(string name)
	{
		base.Name = name;
	}
}
