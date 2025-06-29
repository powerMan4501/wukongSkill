using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum BindingFlags
{
	Default = 0,
	[__DynamicallyInvokable]
	IgnoreCase = 1,
	[__DynamicallyInvokable]
	DeclaredOnly = 2,
	[__DynamicallyInvokable]
	Instance = 4,
	[__DynamicallyInvokable]
	Static = 8,
	[__DynamicallyInvokable]
	Public = 0x10,
	[__DynamicallyInvokable]
	NonPublic = 0x20,
	[__DynamicallyInvokable]
	FlattenHierarchy = 0x40,
	InvokeMethod = 0x100,
	CreateInstance = 0x200,
	GetField = 0x400,
	SetField = 0x800,
	GetProperty = 0x1000,
	SetProperty = 0x2000,
	PutDispProperty = 0x4000,
	PutRefDispProperty = 0x8000,
	[__DynamicallyInvokable]
	ExactBinding = 0x10000,
	SuppressChangeType = 0x20000,
	[__DynamicallyInvokable]
	OptionalParamBinding = 0x40000,
	IgnoreReturn = 0x1000000
}
