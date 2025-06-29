using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ModulationParamMode", "Engine", UnrealModuleType.Engine)]
public enum EModulationParamMode
{
	MPM_Normal,
	MPM_Abs,
	MPM_Direct
}
