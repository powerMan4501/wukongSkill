using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAutoExposureMethodUI", "Engine", UnrealModuleType.Engine)]
public enum EAutoExposureMethodUI
{
	AEM_Histogram,
	AEM_Basic,
	AEM_Manual
}
