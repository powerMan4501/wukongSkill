using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum ParameterAttributes
{
	[__DynamicallyInvokable]
	None = 0,
	[__DynamicallyInvokable]
	In = 1,
	[__DynamicallyInvokable]
	Out = 2,
	[__DynamicallyInvokable]
	Lcid = 4,
	[__DynamicallyInvokable]
	Retval = 8,
	[__DynamicallyInvokable]
	Optional = 0x10,
	ReservedMask = 0xF000,
	[__DynamicallyInvokable]
	HasDefault = 0x1000,
	[__DynamicallyInvokable]
	HasFieldMarshal = 0x2000,
	Reserved3 = 0x4000,
	Reserved4 = 0x8000
}
