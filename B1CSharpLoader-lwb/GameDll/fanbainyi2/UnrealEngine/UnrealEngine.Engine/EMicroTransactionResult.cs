using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMicroTransactionResult", "Engine", UnrealModuleType.Engine)]
public enum EMicroTransactionResult
{
	MTR_Succeeded,
	MTR_Failed,
	MTR_Canceled,
	MTR_RestoredFromServer
}
