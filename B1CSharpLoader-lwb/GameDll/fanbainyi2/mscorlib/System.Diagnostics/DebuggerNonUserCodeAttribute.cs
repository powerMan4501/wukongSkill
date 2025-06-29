using System.Runtime.InteropServices;

namespace System.Diagnostics;

[Serializable]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DebuggerNonUserCodeAttribute : Attribute
{
	[__DynamicallyInvokable]
	public DebuggerNonUserCodeAttribute()
	{
	}
}
