using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public enum UIPermissionClipboard
{
	NoClipboard,
	OwnClipboard,
	AllClipboard
}
