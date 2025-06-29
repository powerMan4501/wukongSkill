using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ELightingBuildQuality", "Engine", UnrealModuleType.Engine)]
public enum ELightingBuildQuality
{
	Quality_Preview,
	Quality_Medium,
	Quality_High,
	Quality_Production
}
