using System.Runtime.InteropServices;

namespace System.IO.IsolatedStorage;

[Serializable]
[Flags]
[ComVisible(true)]
public enum IsolatedStorageScope
{
	None = 0,
	User = 1,
	Domain = 2,
	Assembly = 4,
	Roaming = 8,
	Machine = 0x10,
	Application = 0x20
}
