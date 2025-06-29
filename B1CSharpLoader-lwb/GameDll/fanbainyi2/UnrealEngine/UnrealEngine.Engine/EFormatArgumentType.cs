using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EFormatArgumentType", "Engine", UnrealModuleType.Engine)]
public enum EFormatArgumentType : byte
{
	Int,
	UInt,
	Float,
	Double,
	Text,
	Gender
}
