using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeNamespaceImport : CodeObject
{
	private string nameSpace;

	private CodeLinePragma linePragma;

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

	public string Namespace
	{
		get
		{
			if (nameSpace != null)
			{
				return nameSpace;
			}
			return string.Empty;
		}
		set
		{
			nameSpace = value;
		}
	}

	public CodeNamespaceImport()
	{
	}

	public CodeNamespaceImport(string nameSpace)
	{
		Namespace = nameSpace;
	}
}
