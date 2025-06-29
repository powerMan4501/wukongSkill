using System.Runtime.InteropServices;

namespace System.Security.Policy;

[Serializable]
[Flags]
[ComVisible(true)]
public enum PolicyStatementAttribute
{
	Nothing = 0,
	Exclusive = 1,
	LevelFinal = 2,
	All = 3
}
