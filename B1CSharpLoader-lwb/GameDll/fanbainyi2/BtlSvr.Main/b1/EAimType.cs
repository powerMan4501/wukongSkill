using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AimType")]
public enum EAimType : byte
{
	NONE,
	AIM_TO_CUR_TARGET,
	XYLineFromOwner
}
