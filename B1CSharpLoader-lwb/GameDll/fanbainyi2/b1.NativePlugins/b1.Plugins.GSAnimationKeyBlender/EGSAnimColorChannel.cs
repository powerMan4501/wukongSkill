using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.EGSAnimColorChannel", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public enum EGSAnimColorChannel : byte
{
	GSA_COLOR_MIN,
	GSA_COLOR_RED,
	GSA_COLOR_GREEN,
	GSA_COLOR_BLUE,
	GSA_COLOR_ALPHA
}
