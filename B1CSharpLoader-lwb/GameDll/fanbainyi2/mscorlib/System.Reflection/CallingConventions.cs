using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum CallingConventions
{
	[__DynamicallyInvokable]
	Standard = 1,
	[__DynamicallyInvokable]
	VarArgs = 2,
	[__DynamicallyInvokable]
	Any = 3,
	[__DynamicallyInvokable]
	HasThis = 0x20,
	[__DynamicallyInvokable]
	ExplicitThis = 0x40
}
