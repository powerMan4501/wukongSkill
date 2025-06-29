using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EComponentSocketType", "Engine", UnrealModuleType.Engine)]
public enum EComponentSocketType
{
	Invalid,
	Bone,
	Socket
}
