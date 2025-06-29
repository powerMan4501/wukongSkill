using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EStretchDirection", "Slate", UnrealModuleType.Engine)]
public enum EStretchDirection : byte
{
	Both,
	DownOnly,
	UpOnly
}
