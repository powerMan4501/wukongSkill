using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraMipMapGeneration", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraMipMapGeneration
{
	Disabled,
	PostStage,
	PostSimulate
}
