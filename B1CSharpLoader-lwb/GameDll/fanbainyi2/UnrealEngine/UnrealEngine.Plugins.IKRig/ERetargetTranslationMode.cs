using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/IKRig.ERetargetTranslationMode", "IKRig", UnrealModuleType.EnginePlugin)]
public enum ERetargetTranslationMode : byte
{
	None,
	GloballyScaled,
	Absolute
}
