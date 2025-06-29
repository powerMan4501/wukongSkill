using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EBSelectTargetRangeType")]
public enum EBSelectTargetRangeType : byte
{
	None,
	CameraLock,
	MeeleAttack,
	EnumMax
}
