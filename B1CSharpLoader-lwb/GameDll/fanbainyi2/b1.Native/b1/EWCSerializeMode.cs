using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.EWCSerializeMode", "FuncLibEditor", UnrealModuleType.Game)]
public enum EWCSerializeMode : byte
{
	All,
	LOD_Settings,
	Layer_Settings
}
