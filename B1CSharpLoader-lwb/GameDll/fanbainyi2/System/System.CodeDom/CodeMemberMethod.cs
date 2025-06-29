using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeMemberMethod : CodeTypeMember
{
	private CodeParameterDeclarationExpressionCollection parameters = new CodeParameterDeclarationExpressionCollection();

	private CodeStatementCollection statements = new CodeStatementCollection();

	private CodeTypeReference returnType;

	private CodeTypeReference privateImplements;

	private CodeTypeReferenceCollection implementationTypes;

	private CodeAttributeDeclarationCollection returnAttributes;

	[OptionalField]
	private CodeTypeParameterCollection typeParameters;

	private int populated;

	private const int ParametersCollection = 1;

	private const int StatementsCollection = 2;

	private const int ImplTypesCollection = 4;

	public CodeTypeReference ReturnType
	{
		get
		{
			if (returnType == null)
			{
				returnType = new CodeTypeReference(typeof(void).FullName);
			}
			return returnType;
		}
		set
		{
			returnType = value;
		}
	}

	public CodeStatementCollection Statements
	{
		get
		{
			if ((populated & 2) == 0)
			{
				populated |= 2;
				if (this.PopulateStatements != null)
				{
					this.PopulateStatements(this, EventArgs.Empty);
				}
			}
			return statements;
		}
	}

	public CodeParameterDeclarationExpressionCollection Parameters
	{
		get
		{
			if ((populated & 1) == 0)
			{
				populated |= 1;
				if (this.PopulateParameters != null)
				{
					this.PopulateParameters(this, EventArgs.Empty);
				}
			}
			return parameters;
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
			if ((populated & 4) == 0)
			{
				populated |= 4;
				if (this.PopulateImplementationTypes != null)
				{
					this.PopulateImplementationTypes(this, EventArgs.Empty);
				}
			}
			return implementationTypes;
		}
	}

	public CodeAttributeDeclarationCollection ReturnTypeCustomAttributes
	{
		get
		{
			if (returnAttributes == null)
			{
				returnAttributes = new CodeAttributeDeclarationCollection();
			}
			return returnAttributes;
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

	public event EventHandler PopulateParameters;

	public event EventHandler PopulateStatements;

	public event EventHandler PopulateImplementationTypes;
}
