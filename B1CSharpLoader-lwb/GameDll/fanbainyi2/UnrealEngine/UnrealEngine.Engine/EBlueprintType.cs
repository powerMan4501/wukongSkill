using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EBlueprintType", "Engine", UnrealModuleType.Engine)]
public enum EBlueprintType
{
	BPTYPE_Normal,
	BPTYPE_Const,
	BPTYPE_MacroLibrary,
	BPTYPE_Interface,
	BPTYPE_LevelScript,
	BPTYPE_FunctionLibrary
}
