using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.Util;

public class BGU_TextureUtil
{
	public static UTexture2D CreateTexture2D(int SrcWidth, int SrcHeight, string Name)
	{
		return UGSE_TextureFuncLib.CreateTexture2D(SrcWidth, SrcHeight, Name);
	}

	public static UTexture2D CreateTexture2DFromColoData(int SrcWidth, int SrcHeight, in List<FColor> ColorData, string Name)
	{
		return UGSE_TextureFuncLib.CreateTexture2DFromColorData(SrcWidth, SrcHeight, ColorData, Name);
	}

	public unsafe static void ExportColorDataAsPNG(int SrcWidth, int SrcHeight, string Filepath, in FColor[] Color)
	{
		fixed (FColor* val = Color)
		{
			UGSE_TextureFuncLib.ExportColorDataAsPNG(SrcWidth, SrcHeight, Filepath, FColorBufferPtrHelper.ToPtr(val), Color.Length);
		}
	}

	public unsafe static bool WriteToTexture_RenderingThread(UTexture2D TargetTexture, FColor[] inColor)
	{
		if (TargetTexture == null)
		{
			return false;
		}
		fixed (FColor* ptr = inColor)
		{
			_ = *ptr;
			UGSE_TextureFuncLib.WriteToTexture_RenderingThread(TargetTexture, FColorBufferPtrHelper.ToPtr(ptr), inColor.Length);
			return true;
		}
	}

	public unsafe static bool WriteToTexture_GameThread(UTexture2D TargetTexture, FColor[] inColor)
	{
		if (TargetTexture == null)
		{
			return false;
		}
		fixed (FColor* val = inColor)
		{
			UGSE_TextureFuncLib.WriteToTexture_GameThread(TargetTexture, FColorBufferPtrHelper.ToPtr(val), inColor.Length);
			return true;
		}
	}
}
