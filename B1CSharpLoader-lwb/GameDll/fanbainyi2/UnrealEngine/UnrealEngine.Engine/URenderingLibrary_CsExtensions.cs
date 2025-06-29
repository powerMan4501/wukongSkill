using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class URenderingLibrary_CsExtensions
{
	public static FColor ReadRenderTargetUV(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, float U, float V)
	{
		return URenderingLibrary.ReadRenderTargetUV(WorldContextObject, TextureRenderTarget, U, V);
	}

	public static List<FLinearColor> ReadRenderTargetRawUVArea(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, FBox2D Area, bool bNormalize = true)
	{
		return URenderingLibrary.ReadRenderTargetRawUVArea(WorldContextObject, TextureRenderTarget, Area, bNormalize);
	}

	public static FLinearColor ReadRenderTargetRawUV(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, float U, float V, bool bNormalize = true)
	{
		return URenderingLibrary.ReadRenderTargetRawUV(WorldContextObject, TextureRenderTarget, U, V, bNormalize);
	}

	public static List<FLinearColor> ReadRenderTargetRawPixelArea(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int MinX, int MinY, int MaxX, int MaxY, bool bNormalize = true)
	{
		return URenderingLibrary.ReadRenderTargetRawPixelArea(WorldContextObject, TextureRenderTarget, MinX, MinY, MaxX, MaxY, bNormalize);
	}

	public static FLinearColor ReadRenderTargetRawPixel(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int X, int Y, bool bNormalize = true)
	{
		return URenderingLibrary.ReadRenderTargetRawPixel(WorldContextObject, TextureRenderTarget, X, Y, bNormalize);
	}

	public static bool ReadRenderTargetRaw(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, out List<FLinearColor> OutLinearSamples, bool bNormalize = true)
	{
		return URenderingLibrary.ReadRenderTargetRaw(WorldContextObject, TextureRenderTarget, out OutLinearSamples, bNormalize);
	}

	public static FColor ReadRenderTargetPixel(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int X, int Y)
	{
		return URenderingLibrary.ReadRenderTargetPixel(WorldContextObject, TextureRenderTarget, X, Y);
	}

	public static bool ReadRenderTarget(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, out List<FColor> OutSamples, bool bNormalize = true)
	{
		return URenderingLibrary.ReadRenderTarget(WorldContextObject, TextureRenderTarget, out OutSamples, bNormalize);
	}

	public static UTexture2D ImportFileAsTexture2D(this UWorld WorldContextObject, string Filename)
	{
		return URenderingLibrary.ImportFileAsTexture2D(WorldContextObject, Filename);
	}

	public static UTexture2D ImportBufferAsTexture2D(this UWorld WorldContextObject, List<byte> Buffer)
	{
		return URenderingLibrary.ImportBufferAsTexture2D(WorldContextObject, Buffer);
	}

	public static void ExportTexture2D(this UWorld WorldContextObject, UTexture2D Texture, string FilePath, string FileName)
	{
		URenderingLibrary.ExportTexture2D(WorldContextObject, Texture, FilePath, FileName);
	}

	public static void ExportRenderTarget(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, string FilePath, string FileName)
	{
		URenderingLibrary.ExportRenderTarget(WorldContextObject, TextureRenderTarget, FilePath, FileName);
	}

	public static void EndDrawCanvasToRenderTarget(this UWorld WorldContextObject, FDrawToRenderTargetContext Context)
	{
		URenderingLibrary.EndDrawCanvasToRenderTarget(WorldContextObject, Context);
	}

	public static void DrawMaterialToRenderTarget(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, UMaterialInterface Material)
	{
		URenderingLibrary.DrawMaterialToRenderTarget(WorldContextObject, TextureRenderTarget, Material);
	}

	public static UTextureRenderTargetVolume CreateRenderTargetVolume(this UWorld WorldContextObject, int Width, int Height, int Depth, ETextureRenderTargetFormat Format, FLinearColor ClearColor, bool bAutoGenerateMipMaps)
	{
		return URenderingLibrary.CreateRenderTargetVolume(WorldContextObject, Width, Height, Depth, Format, ClearColor, bAutoGenerateMipMaps);
	}

	public static UTextureRenderTarget2DArray CreateRenderTarget2DArray(this UWorld WorldContextObject, int Width, int Height, int Slices, ETextureRenderTargetFormat Format, FLinearColor ClearColor, bool bAutoGenerateMipMaps)
	{
		return URenderingLibrary.CreateRenderTarget2DArray(WorldContextObject, Width, Height, Slices, Format, ClearColor, bAutoGenerateMipMaps);
	}

	public static UTextureRenderTarget2D CreateRenderTarget2D(this UWorld WorldContextObject, int Width, int Height, ETextureRenderTargetFormat Format, FLinearColor ClearColor, bool bAutoGenerateMipMaps)
	{
		return URenderingLibrary.CreateRenderTarget2D(WorldContextObject, Width, Height, Format, ClearColor, bAutoGenerateMipMaps);
	}

	public static void ConvertRenderTargetToTexture2DEditorOnly(this UWorld WorldContextObject, UTextureRenderTarget2D RenderTarget, UTexture2D Texture)
	{
		URenderingLibrary.ConvertRenderTargetToTexture2DEditorOnly(WorldContextObject, RenderTarget, Texture);
	}

	public static void ClearRenderTarget2D(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, FLinearColor ClearColor)
	{
		URenderingLibrary.ClearRenderTarget2D(WorldContextObject, TextureRenderTarget, ClearColor);
	}

	public static FMatrix CalculateProjectionMatrix(this FMinimalViewInfo MinimalViewInfo)
	{
		return URenderingLibrary.CalculateProjectionMatrix(MinimalViewInfo);
	}

	public static void BeginDrawCanvasToRenderTarget(this UWorld WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, out UCanvas Canvas, out FVector2D Size, out FDrawToRenderTargetContext Context)
	{
		URenderingLibrary.BeginDrawCanvasToRenderTarget(WorldContextObject, TextureRenderTarget, out Canvas, out Size, out Context);
	}
}
