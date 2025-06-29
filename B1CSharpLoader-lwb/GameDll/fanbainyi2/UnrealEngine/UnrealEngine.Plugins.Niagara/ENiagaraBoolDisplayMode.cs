using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraBoolDisplayMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraBoolDisplayMode
{
	DisplayAlways,
	DisplayIfTrue,
	DisplayIfFalse
}
