using UnrealEngine.Runtime;

namespace UnrealEngine.AssetTools;

[UEnum]
[UMetaPath("/Script/AssetTools.ERedirectFixupMode", "AssetTools", UnrealModuleType.Engine)]
public enum ERedirectFixupMode
{
	DeleteFixedUpRedirectors,
	LeaveFixedUpRedirectors
}
