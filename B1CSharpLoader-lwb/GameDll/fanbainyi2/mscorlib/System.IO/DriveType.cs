using System.Runtime.InteropServices;

namespace System.IO;

[Serializable]
[ComVisible(true)]
public enum DriveType
{
	Unknown,
	NoRootDirectory,
	Removable,
	Fixed,
	Network,
	CDRom,
	Ram
}
