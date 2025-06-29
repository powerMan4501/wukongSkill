using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAlphaChannelMode", "Engine", UnrealModuleType.Engine)]
public enum EAlphaChannelMode
{
	Disabled,
	LinearColorSpaceOnly,
	AllowThroughTonemapper
}
