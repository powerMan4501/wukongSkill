using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeCompileUnit : CodeObject
{
	private CodeNamespaceCollection namespaces = new CodeNamespaceCollection();

	private StringCollection assemblies;

	private CodeAttributeDeclarationCollection attributes;

	[OptionalField]
	private CodeDirectiveCollection startDirectives;

	[OptionalField]
	private CodeDirectiveCollection endDirectives;

	public CodeNamespaceCollection Namespaces => namespaces;

	public StringCollection ReferencedAssemblies
	{
		get
		{
			if (assemblies == null)
			{
				assemblies = new StringCollection();
			}
			return assemblies;
		}
	}

	public CodeAttributeDeclarationCollection AssemblyCustomAttributes
	{
		get
		{
			if (attributes == null)
			{
				attributes = new CodeAttributeDeclarationCollection();
			}
			return attributes;
		}
	}

	public CodeDirectiveCollection StartDirectives
	{
		get
		{
			if (startDirectives == null)
			{
				startDirectives = new CodeDirectiveCollection();
			}
			return startDirectives;
		}
	}

	public CodeDirectiveCollection EndDirectives
	{
		get
		{
			if (endDirectives == null)
			{
				endDirectives = new CodeDirectiveCollection();
			}
			return endDirectives;
		}
	}
}
