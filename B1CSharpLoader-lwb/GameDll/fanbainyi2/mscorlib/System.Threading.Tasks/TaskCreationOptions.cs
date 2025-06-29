namespace System.Threading.Tasks;

[Serializable]
[Flags]
[__DynamicallyInvokable]
public enum TaskCreationOptions
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
	RunContinuationsAsynchronously = 0x40
}
