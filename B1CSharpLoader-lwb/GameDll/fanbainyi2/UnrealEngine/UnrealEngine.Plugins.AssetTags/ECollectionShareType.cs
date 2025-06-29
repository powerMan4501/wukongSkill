using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AssetTags;

[UEnum]
[UMetaPath("/Script/AssetTags.ECollectionScriptingShareType", "AssetTags", UnrealModuleType.EnginePlugin)]
public enum ECollectionShareType
{
	Local,
	Private,
	Shared
}
