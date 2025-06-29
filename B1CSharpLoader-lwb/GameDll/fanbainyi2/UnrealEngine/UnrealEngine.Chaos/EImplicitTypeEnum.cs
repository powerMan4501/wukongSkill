using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EImplicitTypeEnum", "Chaos", UnrealModuleType.Engine)]
public enum EImplicitTypeEnum : byte
{
	Chaos_Implicit_Box,
	Chaos_Implicit_Sphere,
	Chaos_Implicit_Capsule,
	Chaos_Implicit_LevelSet,
	Chaos_Implicit_None,
	Chaos_Implicit_Convex,
	Chaos_Max
}
