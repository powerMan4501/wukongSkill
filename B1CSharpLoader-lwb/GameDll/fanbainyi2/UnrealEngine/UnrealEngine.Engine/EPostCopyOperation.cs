using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPostCopyOperation", "Engine", UnrealModuleType.Engine)]
public enum EPostCopyOperation
{
	None,
	LogicalNegateBool
}
