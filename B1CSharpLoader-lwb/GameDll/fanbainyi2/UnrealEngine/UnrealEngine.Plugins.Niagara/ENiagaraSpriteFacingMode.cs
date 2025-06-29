using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraSpriteFacingMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraSpriteFacingMode
{
	FaceCamera,
	FaceCameraPlane,
	CustomFacingVector,
	FaceCameraPosition,
	FaceCameraDistanceBlend
}
