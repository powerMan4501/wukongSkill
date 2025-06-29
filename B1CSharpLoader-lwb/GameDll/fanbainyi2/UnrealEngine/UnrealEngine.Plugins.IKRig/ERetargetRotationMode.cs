using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/IKRig.ERetargetRotationMode", "IKRig", UnrealModuleType.EnginePlugin)]
public enum ERetargetRotationMode : byte
{
	Interpolated,
	OneToOne,
	OneToOneReversed,
	None
}
