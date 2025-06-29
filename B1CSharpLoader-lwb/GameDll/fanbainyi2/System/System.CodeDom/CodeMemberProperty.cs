using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeMemberProperty : CodeTypeMember
{
	private CodeTypeReference type;

	private CodeParameterDeclarationExpressionCollection parameters = new CodeParameterDeclarationExpressionCollection();

	private bool hasGet;

	private bool hasSet;

	private CodeStatementCollection getStatements = new CodeStatementCollection();

	private CodeStatementCollection setStatements = new CodeStatementCollection();

	private CodeTypeReference privateImplements;

	private CodeTypeReferenceCollection implementationTypes;

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

	public bool HasGet
	{
		get
		{
			if (!hasGet)
			{
				return getStatements.Count > 0;
			}
			return true;
		}
		set
		{
			hasGet = value;
			if (!value)
			{
				getStatements.Clear();
			}
		}
	}

	public bool HasSet
	{
		get
		{
			if (!hasSet)
			{
				return setStatements.Count > 0;
			}
			return true;
		}
		set
		{
			hasSet = value;
			if (!value)
			{
				setStatements.Clear();
			}
		}
	}

	public CodeStatementCollection GetStatements => getStatements;

	public CodeStatementCollection SetStatements => setStatements;

	public CodeParameterDeclarationExpressionCollection Parameters => parameters;
}
