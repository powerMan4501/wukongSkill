using System.Runtime.InteropServices;

namespace System.IO;

[Serializable]
[ComVisible(true)]
public enum FileMode
{
	CreateNew = 1,
	Create,
	Open,
	OpenOrCreate,
	Truncate,
	Append
}
