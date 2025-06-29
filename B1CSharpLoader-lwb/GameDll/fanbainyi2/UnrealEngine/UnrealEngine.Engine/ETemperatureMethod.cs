using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETemperatureMethod", "Engine", UnrealModuleType.Engine)]
public enum ETemperatureMethod
{
	TEMP_WhiteBalance,
	TEMP_ColorTemperature
}
