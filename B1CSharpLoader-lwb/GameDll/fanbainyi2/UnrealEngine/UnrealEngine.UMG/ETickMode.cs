using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.ETickMode", "UMG", UnrealModuleType.Engine)]
public enum ETickMode : byte
{
	Disabled,
	Enabled,
	Automatic
}
