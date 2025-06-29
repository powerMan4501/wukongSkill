using UnrealEngine.Engine;

namespace UnrealEngine.ImageWriteQueue;

public static class UImageWriteBlueprintLibrary_CsExtensions
{
	public static void ExportToDisk(this UTexture Texture, string Filename, FImageWriteOptions Options)
	{
		UImageWriteBlueprintLibrary.ExportToDisk(Texture, Filename, Options);
	}
}
