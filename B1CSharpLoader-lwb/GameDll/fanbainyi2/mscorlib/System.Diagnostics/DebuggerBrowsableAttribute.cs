using System.Runtime.InteropServices;

namespace System.Diagnostics;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DebuggerBrowsableAttribute : Attribute
{
	private DebuggerBrowsableState state;

	[__DynamicallyInvokable]
	public DebuggerBrowsableState State
	{
		[__DynamicallyInvokable]
		get
		{
			return state;
		}
	}

	[__DynamicallyInvokable]
	public DebuggerBrowsableAttribute(DebuggerBrowsableState state)
	{
		if (state < DebuggerBrowsableState.Never || state > DebuggerBrowsableState.RootHidden)
		{
			throw new ArgumentOutOfRangeException("state");
		}
		this.state = state;
	}
}
