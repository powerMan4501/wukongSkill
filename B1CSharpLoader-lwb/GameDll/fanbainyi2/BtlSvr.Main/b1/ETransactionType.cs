using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TransactionType")]
public enum ETransactionType : byte
{
	Interact,
	InteractAction
}
