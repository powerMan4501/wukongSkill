using UnrealEngine.Runtime;

namespace UnrealEngine.StatsViewer;

[UEnum]
[UMetaPath("/Script/StatsViewer.ETextureObjectSets", "StatsViewer", UnrealModuleType.Engine)]
public enum ETextureObjectSets
{
	TextureObjectSet_CurrentStreamingLevel,
	TextureObjectSet_AllStreamingLevels,
	TextureObjectSet_SelectedActors,
	TextureObjectSet_SelectedMaterials
}
