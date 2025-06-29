using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraDefaultRendererMotionVectorSetting", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraDefaultRendererMotionVectorSetting
{
	Precise,
	Approximate
}
