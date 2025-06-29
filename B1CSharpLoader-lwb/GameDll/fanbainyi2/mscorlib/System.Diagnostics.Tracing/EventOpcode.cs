using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing;

[FriendAccessAllowed]
[__DynamicallyInvokable]
public enum EventOpcode
{
	[__DynamicallyInvokable]
	Info = 0,
	[__DynamicallyInvokable]
	Start = 1,
	[__DynamicallyInvokable]
	Stop = 2,
	[__DynamicallyInvokable]
	DataCollectionStart = 3,
	[__DynamicallyInvokable]
	DataCollectionStop = 4,
	[__DynamicallyInvokable]
	Extension = 5,
	[__DynamicallyInvokable]
	Reply = 6,
	[__DynamicallyInvokable]
	Resume = 7,
	[__DynamicallyInvokable]
	Suspend = 8,
	[__DynamicallyInvokable]
	Send = 9,
	[__DynamicallyInvokable]
	Receive = 240
}
