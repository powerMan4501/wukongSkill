using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeMemberEvent : CodeTypeMember
{
	private CodeTypeReference type;

	private CodeTypeReference privateImplements;

	private CodeTypeReferenceCollection implementationTypes;

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

	public CodeTypeReference PrivateImplementationType
	{
		get
		{
			return privateImplements;
		}
		set
		{
			privateImplements = value;
		}
	}

	public CodeTypeReferenceCollection ImplementationTypes
	{
		get
		{
			if (implementationTypes == null)
			{
				implementationTypes = new CodeTypeReferenceCollection();
			}
			return implementationTypes;
		}
	}
}
