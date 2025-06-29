using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[UMetaPath("/Script/Synthesis.ETapLineMode", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ETapLineMode
{
	SendToChannel,
	Panning,
	Disabled
}
