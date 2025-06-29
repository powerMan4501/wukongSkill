using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperTileInfo", "Paper2D", UnrealModuleType.EnginePlugin)]
public struct FPaperTileInfo
{
	private static bool FPaperTileInfo_IsValid;

	private static int FPaperTileInfo_StructSize;

	public FPaperTileInfo Copy()
	{
		return this;
	}

	public static FPaperTileInfo FromNative(IntPtr nativeBuffer)
	{
		return new FPaperTileInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPaperTileInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPaperTileInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPaperTileInfo(nativeBuffer + arrayIndex * FPaperTileInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPaperTileInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPaperTileInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPaperTileInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Paper2D.PaperTileInfo");
		}
	}

	public FPaperTileInfo(IntPtr nativeStruct)
	{
		if (!FPaperTileInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Paper2D.PaperTileInfo");
		}
	}

	static FPaperTileInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPaperTileInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPaperTileInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Paper2D.PaperTileInfo");
		FPaperTileInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FPaperTileInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Paper2D.PaperTileInfo", FPaperTileInfo_IsValid);
	}
}
