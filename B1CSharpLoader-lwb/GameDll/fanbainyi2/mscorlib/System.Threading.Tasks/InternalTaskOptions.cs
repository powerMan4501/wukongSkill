namespace System.Threading.Tasks;

[Serializable]
[Flags]
internal enum InternalTaskOptions
{
	None = 0,
	InternalOptionsMask = 0xFF00,
	ChildReplica = 0x100,
	ContinuationTask = 0x200,
	PromiseTask = 0x400,
	SelfReplicating = 0x800,
	LazyCancellation = 0x1000,
	QueuedByRuntime = 0x2000,
	DoNotDispose = 0x4000
}
