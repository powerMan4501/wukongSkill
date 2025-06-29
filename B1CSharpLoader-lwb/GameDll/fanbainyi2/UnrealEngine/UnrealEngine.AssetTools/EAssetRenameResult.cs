using UnrealEngine.Runtime;

namespace UnrealEngine.AssetTools;

[UEnum]
[UMetaPath("/Script/AssetTools.EAssetRenameResult", "AssetTools", UnrealModuleType.Engine)]
public enum EAssetRenameResult
{
	Failure,
	Success,
	Pending
}
