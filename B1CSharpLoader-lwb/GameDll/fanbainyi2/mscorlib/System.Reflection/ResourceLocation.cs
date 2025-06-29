using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum ResourceLocation
{
	[__DynamicallyInvokable]
	Embedded = 1,
	[__DynamicallyInvokable]
	ContainedInAnotherAssembly = 2,
	[__DynamicallyInvokable]
	ContainedInManifestFile = 4
}
