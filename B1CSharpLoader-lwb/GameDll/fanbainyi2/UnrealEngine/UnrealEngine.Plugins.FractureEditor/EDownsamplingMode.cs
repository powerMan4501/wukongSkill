using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.EDownsamplingMode", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum EDownsamplingMode
{
	Random,
	UniformSpacing,
	KeepSharp
}
