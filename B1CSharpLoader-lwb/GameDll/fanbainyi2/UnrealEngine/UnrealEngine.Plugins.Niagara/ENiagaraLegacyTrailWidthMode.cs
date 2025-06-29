using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraLegacyTrailWidthMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraLegacyTrailWidthMode
{
	FromCentre,
	FromFirst,
	FromSecond
}
