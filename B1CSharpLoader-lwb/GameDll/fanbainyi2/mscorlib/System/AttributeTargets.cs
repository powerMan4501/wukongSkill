using System.Runtime.InteropServices;

namespace System;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum AttributeTargets
{
	[__DynamicallyInvokable]
	Assembly = 1,
	[__DynamicallyInvokable]
	Module = 2,
	[__DynamicallyInvokable]
	Class = 4,
	[__DynamicallyInvokable]
	Struct = 8,
	[__DynamicallyInvokable]
	Enum = 0x10,
	[__DynamicallyInvokable]
	Constructor = 0x20,
	[__DynamicallyInvokable]
	Method = 0x40,
	[__DynamicallyInvokable]
	Property = 0x80,
	[__DynamicallyInvokable]
	Field = 0x100,
	[__DynamicallyInvokable]
	Event = 0x200,
	[__DynamicallyInvokable]
	Interface = 0x400,
	[__DynamicallyInvokable]
	Parameter = 0x800,
	[__DynamicallyInvokable]
	Delegate = 0x1000,
	[__DynamicallyInvokable]
	ReturnValue = 0x2000,
	[__DynamicallyInvokable]
	GenericParameter = 0x4000,
	[__DynamicallyInvokable]
	All = 0x7FFF
}
