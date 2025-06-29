namespace System.Threading.Tasks;

[Serializable]
[Flags]
[__DynamicallyInvokable]
public enum TaskContinuationOptions
{
	[__DynamicallyInvokable]
	None = 0,
	[__DynamicallyInvokable]
	PreferFairness = 1,
	[__DynamicallyInvokable]
	LongRunning = 2,
	[__DynamicallyInvokable]
	AttachedToParent = 4,
	[__DynamicallyInvokable]
	DenyChildAttach = 8,
	[__DynamicallyInvokable]
	HideScheduler = 0x10,
	[__DynamicallyInvokable]
	LazyCancellation = 0x20,
	[__DynamicallyInvokable]
	RunContinuationsAsynchronously = 0x40,
	[__DynamicallyInvokable]
	NotOnRanToCompletion = 0x10000,
	[__DynamicallyInvokable]
	NotOnFaulted = 0x20000,
	[__DynamicallyInvokable]
	NotOnCanceled = 0x40000,
	[__DynamicallyInvokable]
	OnlyOnRanToCompletion = 0x60000,
	[__DynamicallyInvokable]
	OnlyOnFaulted = 0x50000,
	[__DynamicallyInvokable]
	OnlyOnCanceled = 0x30000,
	[__DynamicallyInvokable]
	ExecuteSynchronously = 0x80000
}
