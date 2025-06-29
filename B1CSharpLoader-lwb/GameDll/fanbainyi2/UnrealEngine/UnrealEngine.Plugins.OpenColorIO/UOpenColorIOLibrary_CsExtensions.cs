using UnrealEngine.Engine;

namespace UnrealEngine.Plugins.OpenColorIO;

public static class UOpenColorIOLibrary_CsExtensions
{
	public static bool ApplyColorSpaceTransform(this UWorld WorldContextObject, FOpenColorIOColorConversionSettings ConversionSettings, UTexture InputTexture, UTextureRenderTarget2D OutputRenderTarget)
	{
		return UOpenColorIOLibrary.ApplyColorSpaceTransform(WorldContextObject, ConversionSettings, InputTexture, OutputRenderTarget);
	}
}
