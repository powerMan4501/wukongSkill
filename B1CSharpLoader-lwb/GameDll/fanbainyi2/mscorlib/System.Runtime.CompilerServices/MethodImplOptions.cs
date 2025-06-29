using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum MethodImplOptions
{
	Unmanaged = 4,
	ForwardRef = 0x10,
	[__DynamicallyInvokable]
	PreserveSig = 0x80,
	InternalCall = 0x1000,
	Synchronized = 0x20,
	[__DynamicallyInvokable]
	NoInlining = 8,
	[ComVisible(false)]
	[__DynamicallyInvokable]
	AggressiveInlining = 0x100,
	[__DynamicallyInvokable]
	NoOptimization = 0x40,
	SecurityMitigations = 0x400
}
