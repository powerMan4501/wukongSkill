using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[UMetaPath("/Script/Chaos.ECollisionTypeEnum", "Chaos", UnrealModuleType.Engine)]
public enum ECollisionTypeEnum
{
	Chaos_Volumetric,
	Chaos_Surface_Volumetric,
	Chaos_Max
}
