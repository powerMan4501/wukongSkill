using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[Flags]
[ComVisible(true)]
public enum FileIOPermissionAccess
{
	NoAccess = 0,
	Read = 1,
	Write = 2,
	Append = 4,
	PathDiscovery = 8,
	AllAccess = 0xF
}
