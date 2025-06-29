using System.Runtime.InteropServices;

namespace System.Threading;

[Serializable]
[ComVisible(true)]
public enum ThreadPriority
{
	Lowest,
	BelowNormal,
	Normal,
	AboveNormal,
	Highest
}
