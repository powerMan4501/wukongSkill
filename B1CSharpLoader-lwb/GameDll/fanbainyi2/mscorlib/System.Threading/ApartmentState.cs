using System.Runtime.InteropServices;

namespace System.Threading;

[Serializable]
[ComVisible(true)]
public enum ApartmentState
{
	STA,
	MTA,
	Unknown
}
