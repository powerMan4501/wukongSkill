using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeTypeMember : CodeObject
{
	private MemberAttributes attributes = (MemberAttributes)20482;

	private string name;

	private CodeCommentStatementCollection comments = new CodeCommentStatementCollection();

	private CodeAttributeDeclarationCollection customAttributes;

	private CodeLinePragma linePragma;

	[OptionalField]
	private CodeDirectiveCollection startDirectives;

	[OptionalField]
	private CodeDirectiveCollection endDirectives;

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

	public MemberAttributes Attributes
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

	public CodeLinePragma LinePragma
	{
		get
		{
			return linePragma;
		}
		set
		{
			linePragma = value;
		}
	}

	public CodeCommentStatementCollection Comments => comments;

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
