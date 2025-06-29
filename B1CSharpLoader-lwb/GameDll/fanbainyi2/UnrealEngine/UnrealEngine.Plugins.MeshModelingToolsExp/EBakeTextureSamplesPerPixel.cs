using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EBakeTextureSamplesPerPixel", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EBakeTextureSamplesPerPixel
{
	Sample1 = 1,
	Sample4 = 4,
	Sample16 = 0x10,
	Sample64 = 0x40,
	Sample256 = 0x100
}
