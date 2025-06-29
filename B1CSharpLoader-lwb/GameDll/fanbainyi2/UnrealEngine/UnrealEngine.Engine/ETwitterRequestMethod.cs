using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETwitterRequestMethod", "Engine", UnrealModuleType.Engine)]
public enum ETwitterRequestMethod
{
	TRM_Get,
	TRM_Post,
	TRM_Delete
}
