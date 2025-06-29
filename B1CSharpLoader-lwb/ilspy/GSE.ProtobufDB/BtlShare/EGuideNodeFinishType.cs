using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.GuideNodeFinishType")]
public enum EGuideNodeFinishType : byte
{
	None,
	LockTarget,
	SwitchLockTarget,
	CastSkill,
	DrinkBloodBottle
}
