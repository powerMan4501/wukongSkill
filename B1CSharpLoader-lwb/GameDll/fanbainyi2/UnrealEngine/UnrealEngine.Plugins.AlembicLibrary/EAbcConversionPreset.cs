using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.EAbcConversionPreset", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public enum EAbcConversionPreset : byte
{
	Maya,
	Max,
	Custom
}
