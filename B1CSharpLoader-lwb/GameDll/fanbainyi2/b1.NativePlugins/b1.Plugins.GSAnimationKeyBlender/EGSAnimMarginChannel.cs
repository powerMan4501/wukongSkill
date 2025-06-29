using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.EGSAnimMarginChannel", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public enum EGSAnimMarginChannel : byte
{
	GSA_MARGIN_MIN,
	GSA_MARGIN_TOP,
	GSA_MARGIN_LEFT,
	GSA_MARGIN_RIGHT,
	GSA_MARGIN_BOTTOM
}
