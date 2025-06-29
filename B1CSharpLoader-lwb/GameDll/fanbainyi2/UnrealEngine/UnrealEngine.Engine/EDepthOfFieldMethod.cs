using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EDepthOfFieldMethod", "Engine", UnrealModuleType.Engine)]
public enum EDepthOfFieldMethod
{
	DOFM_BokehDOF,
	DOFM_Gaussian,
	DOFM_CircleDOF
}
