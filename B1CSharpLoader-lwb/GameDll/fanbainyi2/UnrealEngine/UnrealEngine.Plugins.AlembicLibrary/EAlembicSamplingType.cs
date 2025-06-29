using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.EAlembicSamplingType", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public enum EAlembicSamplingType : byte
{
	PerFrame,
	PerXFrames,
	PerTimeStep
}
