using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraCollisionMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraCollisionMode
{
	None,
	SceneGeometry,
	DepthBuffer,
	DistanceField
}
