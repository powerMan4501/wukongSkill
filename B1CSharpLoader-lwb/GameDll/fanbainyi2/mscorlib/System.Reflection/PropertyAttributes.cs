using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum PropertyAttributes
{
	[__DynamicallyInvokable]
	None = 0,
	[__DynamicallyInvokable]
	SpecialName = 0x200,
	ReservedMask = 0xF400,
	[__DynamicallyInvokable]
	RTSpecialName = 0x400,
	[__DynamicallyInvokable]
	HasDefault = 0x1000,
	Reserved2 = 0x2000,
	Reserved3 = 0x4000,
	Reserved4 = 0x8000
}
