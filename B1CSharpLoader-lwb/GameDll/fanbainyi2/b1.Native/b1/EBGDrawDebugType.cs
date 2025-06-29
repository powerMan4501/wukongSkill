using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGDrawDebugType", "b1", UnrealModuleType.Game)]
public enum EBGDrawDebugType : byte
{
	None,
	Movement,
	QTE
}
