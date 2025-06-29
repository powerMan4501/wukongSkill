using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGWSubsystemType", "b1", UnrealModuleType.Game)]
public enum EBGWSubsystemType : byte
{
	Unknown,
	Null,
	Steam,
	Epic,
	Tencent,
	GDK,
	PS5
}
