using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMonoChannelUpmixMethod", "Engine", UnrealModuleType.Engine)]
public enum EMonoChannelUpmixMethod
{
	Linear,
	EqualPower,
	FullVolume
}
