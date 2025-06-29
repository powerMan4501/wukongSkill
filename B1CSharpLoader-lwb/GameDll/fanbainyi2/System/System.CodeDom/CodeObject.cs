using System.Collections;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeObject
{
	private IDictionary userData;

	public IDictionary UserData
	{
		get
		{
			if (userData == null)
			{
				userData = new ListDictionary();
			}
			return userData;
		}
	}
}
