using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeTypeConstructor : CodeMemberMethod
{
	public CodeTypeConstructor()
	{
		base.Name = ".cctor";
	}
}
