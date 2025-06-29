using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum EventAttributes
{
	[__DynamicallyInvokable]
	None = 0,
	[__DynamicallyInvokable]
	SpecialName = 0x200,
	ReservedMask = 0x400,
	[__DynamicallyInvokable]
	RTSpecialName = 0x400
}
