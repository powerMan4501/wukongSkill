using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EPDGLinkState", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EPDGLinkState
{
	Inactive,
	Linking,
	Linked,
	Error_Not_Linked
}
