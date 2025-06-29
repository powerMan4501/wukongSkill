using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraRendererMotionVectorSetting", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraRendererMotionVectorSetting
{
	AutoDetect,
	Precise,
	Approximate,
	Disable
}
