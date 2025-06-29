using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.ETextWrappingPolicy", "Slate", UnrealModuleType.Engine)]
public enum ETextWrappingPolicy : byte
{
	DefaultWrapping,
	AllowPerCharacterWrapping
}
