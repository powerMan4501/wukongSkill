using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BinkMediaPlayer;

[UEnum]
[UMetaPath("/Script/BinkMediaPlayer.EBinkMediaPlayerBinkDrawStyle", "BinkMediaPlayer", UnrealModuleType.EnginePlugin)]
public enum EBinkMediaPlayerBinkDrawStyle
{
	BMASM_Bink_DS_RenderToTexture,
	BMASM_Bink_DS_OverlayFillScreenWithAspectRatio,
	BMASM_Bink_DS_OverlayOriginalMovieSize,
	BMASM_Bink_DS_OverlayFillScreen,
	BMASM_Bink_DS_OverlaySpecificDestinationRectangle
}
