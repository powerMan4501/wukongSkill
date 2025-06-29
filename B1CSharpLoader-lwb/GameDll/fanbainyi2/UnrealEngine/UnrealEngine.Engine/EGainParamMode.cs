using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EGainParamMode", "Engine", UnrealModuleType.Engine)]
public enum EGainParamMode : byte
{
	Linear,
	Decibels
}
