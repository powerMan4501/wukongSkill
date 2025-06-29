using System.Runtime.InteropServices;

namespace System.Diagnostics;

[Serializable]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DebuggerHiddenAttribute : Attribute
{
	[__DynamicallyInvokable]
	public DebuggerHiddenAttribute()
	{
	}
}
