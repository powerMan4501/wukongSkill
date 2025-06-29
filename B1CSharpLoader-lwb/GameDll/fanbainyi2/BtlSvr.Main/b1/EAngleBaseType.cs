using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AngleBaseType")]
public enum EAngleBaseType : byte
{
	Self2Target,
	Target2Self,
	SelfXAxis
}
