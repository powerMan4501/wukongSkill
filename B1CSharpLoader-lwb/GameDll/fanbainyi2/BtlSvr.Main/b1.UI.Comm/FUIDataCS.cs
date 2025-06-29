using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.UI.Comm;

public class FUIDataCS
{
	public List<FWidgetConfigCS> Con;

	public List<FImageWidgetCS> Img;

	public List<FTextWidgetCS> Text;

	public UTexture2D AdvancedHitTexture;

	public UDataAsset AdvancedHitDA;

	public float AdvancedHitAlpha;
}
