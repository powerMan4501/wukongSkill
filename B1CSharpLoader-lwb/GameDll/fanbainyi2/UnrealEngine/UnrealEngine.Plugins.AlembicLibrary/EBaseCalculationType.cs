using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.EBaseCalculationType", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public enum EBaseCalculationType : byte
{
	None,
	PercentageBased,
	FixedNumber,
	NoCompression
}
