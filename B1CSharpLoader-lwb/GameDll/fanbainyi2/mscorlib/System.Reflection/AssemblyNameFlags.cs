using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum AssemblyNameFlags
{
	[__DynamicallyInvokable]
	None = 0,
	[__DynamicallyInvokable]
	PublicKey = 1,
	EnableJITcompileOptimizer = 0x4000,
	EnableJITcompileTracking = 0x8000,
	[__DynamicallyInvokable]
	Retargetable = 0x100
}
