using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeStatement : CodeObject
{
	private CodeLinePragma linePragma;

	[OptionalField]
	private CodeDirectiveCollection startDirectives;

	[OptionalField]
	private CodeDirectiveCollection endDirectives;

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
