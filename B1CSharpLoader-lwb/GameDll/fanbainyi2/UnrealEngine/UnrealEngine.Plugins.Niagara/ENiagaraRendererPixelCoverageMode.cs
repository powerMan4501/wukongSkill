using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraRendererPixelCoverageMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraRendererPixelCoverageMode
{
	Automatic,
	Disabled,
	Enabled,
	Enabled_RGBA,
	Enabled_RGB,
	Enabled_A
}
