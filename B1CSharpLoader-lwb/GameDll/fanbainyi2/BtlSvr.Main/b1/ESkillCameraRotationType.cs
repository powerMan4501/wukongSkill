using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.SkillCameraRotationType")]
public enum ESkillCameraRotationType : byte
{
	UseUnitRotation,
	UseControllerRotation
}
