using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TransactionTaskState")]
public enum ETransactionTaskState : byte
{
	Init,
	Runing,
	Aborted,
	Finished
}
