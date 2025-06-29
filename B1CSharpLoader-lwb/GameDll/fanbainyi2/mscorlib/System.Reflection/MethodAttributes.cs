using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum MethodAttributes
{
	[__DynamicallyInvokable]
	MemberAccessMask = 7,
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
	Final = 0x20,
	[__DynamicallyInvokable]
	Virtual = 0x40,
	[__DynamicallyInvokable]
	HideBySig = 0x80,
	[__DynamicallyInvokable]
	CheckAccessOnOverride = 0x200,
	[__DynamicallyInvokable]
	VtableLayoutMask = 0x100,
	[__DynamicallyInvokable]
	ReuseSlot = 0,
	[__DynamicallyInvokable]
	NewSlot = 0x100,
	[__DynamicallyInvokable]
	Abstract = 0x400,
	[__DynamicallyInvokable]
	SpecialName = 0x800,
	[__DynamicallyInvokable]
	PinvokeImpl = 0x2000,
	[__DynamicallyInvokable]
	UnmanagedExport = 8,
	[__DynamicallyInvokable]
	RTSpecialName = 0x1000,
	ReservedMask = 0xD000,
	[__DynamicallyInvokable]
	HasSecurity = 0x4000,
	[__DynamicallyInvokable]
	RequireSecObject = 0x8000
}
