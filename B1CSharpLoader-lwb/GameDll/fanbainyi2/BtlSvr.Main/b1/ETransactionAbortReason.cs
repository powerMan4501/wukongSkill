using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TransactionAbortReason")]
public enum ETransactionAbortReason : byte
{
	Unknow,
	PlayerLogOut
}
