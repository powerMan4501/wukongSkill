using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMicroTransactionDelegate", "Engine", UnrealModuleType.Engine)]
public enum EMicroTransactionDelegate
{
	MTD_PurchaseQueryComplete,
	MTD_PurchaseComplete
}
