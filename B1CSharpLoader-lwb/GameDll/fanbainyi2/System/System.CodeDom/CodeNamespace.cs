using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeNamespace : CodeObject
{
	private string name;

	private CodeNamespaceImportCollection imports = new CodeNamespaceImportCollection();

	private CodeCommentStatementCollection comments = new CodeCommentStatementCollection();

	private CodeTypeDeclarationCollection classes = new CodeTypeDeclarationCollection();

	private CodeNamespaceCollection namespaces = new CodeNamespaceCollection();

	private int populated;

	private const int ImportsCollection = 1;

	private const int CommentsCollection = 2;

	private const int TypesCollection = 4;

	public CodeTypeDeclarationCollection Types
	{
		get
		{
			if ((populated & 4) == 0)
			{
				populated |= 4;
				if (this.PopulateTypes != null)
				{
					this.PopulateTypes(this, EventArgs.Empty);
				}
			}
			return classes;
		}
	}

	public CodeNamespaceImportCollection Imports
	{
		get
		{
			if ((populated & 1) == 0)
			{
				populated |= 1;
				if (this.PopulateImports != null)
				{
					this.PopulateImports(this, EventArgs.Empty);
				}
			}
			return imports;
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

	public CodeCommentStatementCollection Comments
	{
		get
		{
			if ((populated & 2) == 0)
			{
				populated |= 2;
				if (this.PopulateComments != null)
				{
					this.PopulateComments(this, EventArgs.Empty);
				}
			}
			return comments;
		}
	}

	public event EventHandler PopulateComments;

	public event EventHandler PopulateImports;

	public event EventHandler PopulateTypes;

	public CodeNamespace()
	{
	}

	public CodeNamespace(string name)
	{
		Name = name;
	}

	private CodeNamespace(SerializationInfo info, StreamingContext context)
	{
	}
}
