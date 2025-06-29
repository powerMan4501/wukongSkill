using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TransactionState")]
public enum ETransactionState : byte
{
	Starting,
	Runing,
	Aborted,
	Finished
}
