using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraSpriteAlignment", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraSpriteAlignment
{
	Unaligned,
	VelocityAligned,
	CustomAlignment
}
