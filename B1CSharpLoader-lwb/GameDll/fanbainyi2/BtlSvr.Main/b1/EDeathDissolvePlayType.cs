using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.DeathDissolvePlayType")]
public enum EDeathDissolvePlayType : byte
{
	[DisplayName("死亡动画结束时")]
	DeadAMEnd,
	[DisplayName("死亡动画开始时")]
	DeadAMBegin
}
