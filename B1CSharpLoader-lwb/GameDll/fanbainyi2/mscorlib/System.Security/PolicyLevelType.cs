using System.Runtime.InteropServices;

namespace System.Security;

[Serializable]
[ComVisible(true)]
public enum PolicyLevelType
{
	User,
	Machine,
	Enterprise,
	AppDomain
}
