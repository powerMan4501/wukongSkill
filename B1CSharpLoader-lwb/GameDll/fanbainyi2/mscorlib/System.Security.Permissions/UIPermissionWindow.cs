using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public enum UIPermissionWindow
{
	NoWindows,
	SafeSubWindows,
	SafeTopLevelWindows,
	AllWindows
}
