using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECompositeTextureMode", "Engine", UnrealModuleType.Engine)]
public enum ECompositeTextureMode
{
	CTM_Disabled,
	CTM_NormalRoughnessToRed,
	CTM_NormalRoughnessToGreen,
	CTM_NormalRoughnessToBlue,
	CTM_NormalRoughnessToAlpha
}
