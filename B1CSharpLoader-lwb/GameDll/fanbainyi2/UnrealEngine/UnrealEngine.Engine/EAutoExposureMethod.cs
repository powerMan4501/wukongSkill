using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAutoExposureMethod", "Engine", UnrealModuleType.Engine)]
public enum EAutoExposureMethod
{
	AEM_Histogram,
	AEM_Basic,
	AEM_Manual
}
