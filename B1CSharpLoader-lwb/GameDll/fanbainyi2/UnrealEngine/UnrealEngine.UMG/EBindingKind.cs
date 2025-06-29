using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[UMetaPath("/Script/UMG.EBindingKind", "UMG", UnrealModuleType.Engine)]
public enum EBindingKind
{
	Function,
	Property
}
