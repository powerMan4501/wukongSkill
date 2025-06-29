using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAdManagerDelegate", "Engine", UnrealModuleType.Engine)]
public enum EAdManagerDelegate
{
	AMD_ClickedBanner,
	AMD_UserClosedAd
}
