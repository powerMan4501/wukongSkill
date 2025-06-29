using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum FieldAttributes
{
	[__DynamicallyInvokable]
	FieldAccessMask = 7,
	[__DynamicallyInvokable]
	PrivateScope = 0,
	[__DynamicallyInvokable]
	Private = 1,
	[__DynamicallyInvokable]
	FamANDAssem = 2,
	[__DynamicallyInvokable]
	Assembly = 3,
	[__DynamicallyInvokable]
	Family = 4,
	[__DynamicallyInvokable]
	FamORAssem = 5,
	[__DynamicallyInvokable]
	Public = 6,
	[__DynamicallyInvokable]
	Static = 0x10,
	[__DynamicallyInvokable]
	InitOnly = 0x20,
	[__DynamicallyInvokable]
	Literal = 0x40,
	[__DynamicallyInvokable]
	NotSerialized = 0x80,
	[__DynamicallyInvokable]
	SpecialName = 0x200,
	[__DynamicallyInvokable]
	PinvokeImpl = 0x2000,
	ReservedMask = 0x9500,
	[__DynamicallyInvokable]
	RTSpecialName = 0x400,
	[__DynamicallyInvokable]
	HasFieldMarshal = 0x1000,
	[__DynamicallyInvokable]
	HasDefault = 0x8000,
	[__DynamicallyInvokable]
	HasFieldRVA = 0x100
}
