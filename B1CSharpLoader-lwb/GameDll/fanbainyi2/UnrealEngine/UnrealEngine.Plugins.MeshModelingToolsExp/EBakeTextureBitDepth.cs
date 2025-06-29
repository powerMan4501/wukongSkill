using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EBakeTextureBitDepth", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EBakeTextureBitDepth
{
	ChannelBits8,
	ChannelBits16
}
