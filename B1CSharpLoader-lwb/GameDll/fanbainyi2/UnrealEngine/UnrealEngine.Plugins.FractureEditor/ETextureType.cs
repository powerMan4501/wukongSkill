using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.ETextureType", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum ETextureType
{
	ThicknessAndSurfaceAttributes,
	SpatialGradients,
	Normals
}
