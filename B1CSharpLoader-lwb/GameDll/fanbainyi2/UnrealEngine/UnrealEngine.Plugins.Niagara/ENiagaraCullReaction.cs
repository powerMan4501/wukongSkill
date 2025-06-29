using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraCullReaction", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraCullReaction
{
	Deactivate,
	DeactivateImmediate,
	DeactivateResume,
	DeactivateImmediateResume
}
