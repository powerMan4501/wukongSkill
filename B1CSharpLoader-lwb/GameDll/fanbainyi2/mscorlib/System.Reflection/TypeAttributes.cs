using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum TypeAttributes
{
	[__DynamicallyInvokable]
	VisibilityMask = 7,
	[__DynamicallyInvokable]
	NotPublic = 0,
	[__DynamicallyInvokable]
	Public = 1,
	[__DynamicallyInvokable]
	NestedPublic = 2,
	[__DynamicallyInvokable]
	NestedPrivate = 3,
	[__DynamicallyInvokable]
	NestedFamily = 4,
	[__DynamicallyInvokable]
	NestedAssembly = 5,
	[__DynamicallyInvokable]
	NestedFamANDAssem = 6,
	[__DynamicallyInvokable]
	NestedFamORAssem = 7,
	[__DynamicallyInvokable]
	LayoutMask = 0x18,
	[__DynamicallyInvokable]
	AutoLayout = 0,
	[__DynamicallyInvokable]
	SequentialLayout = 8,
	[__DynamicallyInvokable]
	ExplicitLayout = 0x10,
	[__DynamicallyInvokable]
	ClassSemanticsMask = 0x20,
	[__DynamicallyInvokable]
	Class = 0,
	[__DynamicallyInvokable]
	Interface = 0x20,
	[__DynamicallyInvokable]
	Abstract = 0x80,
	[__DynamicallyInvokable]
	Sealed = 0x100,
	[__DynamicallyInvokable]
	SpecialName = 0x400,
	[__DynamicallyInvokable]
	Import = 0x1000,
	[__DynamicallyInvokable]
	Serializable = 0x2000,
	[ComVisible(false)]
	[__DynamicallyInvokable]
	WindowsRuntime = 0x4000,
	[__DynamicallyInvokable]
	StringFormatMask = 0x30000,
	[__DynamicallyInvokable]
	AnsiClass = 0,
	[__DynamicallyInvokable]
	UnicodeClass = 0x10000,
	[__DynamicallyInvokable]
	AutoClass = 0x20000,
	[__DynamicallyInvokable]
	CustomFormatClass = 0x30000,
	[__DynamicallyInvokable]
	CustomFormatMask = 0xC00000,
	[__DynamicallyInvokable]
	BeforeFieldInit = 0x100000,
	ReservedMask = 0x40800,
	[__DynamicallyInvokable]
	RTSpecialName = 0x800,
	[__DynamicallyInvokable]
	HasSecurity = 0x40000
}
