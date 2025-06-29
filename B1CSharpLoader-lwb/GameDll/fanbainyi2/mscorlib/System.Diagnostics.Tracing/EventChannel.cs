using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing;

[FriendAccessAllowed]
[__DynamicallyInvokable]
public enum EventChannel : byte
{
	[__DynamicallyInvokable]
	None = 0,
	[__DynamicallyInvokable]
	Admin = 16,
	[__DynamicallyInvokable]
	Operational = 17,
	[__DynamicallyInvokable]
	Analytic = 18,
	[__DynamicallyInvokable]
	Debug = 19
}
