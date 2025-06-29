using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPropertyAccessObjectType", "Engine", UnrealModuleType.Engine)]
public enum EPropertyAccessObjectType
{
	None,
	Object,
	WeakObject,
	SoftObject
}
