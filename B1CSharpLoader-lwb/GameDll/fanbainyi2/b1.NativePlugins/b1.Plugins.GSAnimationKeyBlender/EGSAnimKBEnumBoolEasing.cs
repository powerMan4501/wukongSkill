using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.EGSAnimKBEnumBoolEasing", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public enum EGSAnimKBEnumBoolEasing : byte
{
	GSEnd,
	GSBegin,
	GSCalc,
	GSHalf
}
