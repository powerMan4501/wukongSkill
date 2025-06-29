using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.EAirWallType", "FuncLibEditor", UnrealModuleType.Game)]
public enum EAirWallType : byte
{
	Normal,
	Cliff,
	Camera
}
