using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.EWindowVisibility", "UMG", UnrealModuleType.Engine)]
public enum EWindowVisibility : byte
{
	Visible,
	SelfHitTestInvisible
}
