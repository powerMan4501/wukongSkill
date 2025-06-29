using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.FDataDrivenCVarType", "Engine", UnrealModuleType.Engine)]
public enum EFDataDrivenCVarType : byte
{
	CVarFloat,
	CVarInt,
	CVarBool
}
