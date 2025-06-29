using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum CompareOptions
{
	[__DynamicallyInvokable]
	None = 0,
	[__DynamicallyInvokable]
	IgnoreCase = 1,
	[__DynamicallyInvokable]
	IgnoreNonSpace = 2,
	[__DynamicallyInvokable]
	IgnoreSymbols = 4,
	[__DynamicallyInvokable]
	IgnoreKanaType = 8,
	[__DynamicallyInvokable]
	IgnoreWidth = 0x10,
	[__DynamicallyInvokable]
	OrdinalIgnoreCase = 0x10000000,
	[__DynamicallyInvokable]
	StringSort = 0x20000000,
	[__DynamicallyInvokable]
	Ordinal = 0x40000000
}
