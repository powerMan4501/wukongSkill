using UnrealEngine.Engine;

namespace b1;

public class FKeyTextureInfo
{
	public UTexture2D Texture { get; set; }

	public UTexture2D InlineTexture { get; set; }

	public float Offset { get; set; }

	public int BgType { get; set; }

	public FKeyTextureInfo(UTexture2D InTexture, float InOffset, int InBgType)
	{
		Texture = InTexture;
		Offset = InOffset;
		BgType = InBgType;
	}
}
