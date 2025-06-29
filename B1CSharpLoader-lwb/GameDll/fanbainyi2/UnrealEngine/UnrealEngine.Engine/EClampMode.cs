using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EClampMode", "Engine", UnrealModuleType.Engine)]
public enum EClampMode
{
	CMODE_Clamp,
	CMODE_ClampMin,
	CMODE_ClampMax
}
