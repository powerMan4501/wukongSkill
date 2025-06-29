using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraMeshFacingMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraMeshFacingMode
{
	Default,
	Velocity,
	CameraPosition,
	CameraPlane
}
