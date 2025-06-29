using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperTerrainMaterialRule", "Paper2D", UnrealModuleType.EnginePlugin)]
public struct FPaperTerrainMaterialRule
{
	private static bool FPaperTerrainMaterialRule_IsValid;

	private static int FPaperTerrainMaterialRule_StructSize;

	public FPaperTerrainMaterialRule Copy()
	{
		return this;
	}

	public static FPaperTerrainMaterialRule FromNative(IntPtr nativeBuffer)
	{
		return new FPaperTerrainMaterialRule(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPaperTerrainMaterialRule value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPaperTerrainMaterialRule FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPaperTerrainMaterialRule(nativeBuffer + arrayIndex * FPaperTerrainMaterialRule_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPaperTerrainMaterialRule value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPaperTerrainMaterialRule_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPaperTerrainMaterialRule_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Paper2D.PaperTerrainMaterialRule");
		}
	}

	public FPaperTerrainMaterialRule(IntPtr nativeStruct)
	{
		if (!FPaperTerrainMaterialRule_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Paper2D.PaperTerrainMaterialRule");
		}
	}

	static FPaperTerrainMaterialRule()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPaperTerrainMaterialRule)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPaperTerrainMaterialRule));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Paper2D.PaperTerrainMaterialRule");
		FPaperTerrainMaterialRule_StructSize = NativeReflection.GetStructSize(intPtr);
		FPaperTerrainMaterialRule_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Paper2D.PaperTerrainMaterialRule", FPaperTerrainMaterialRule_IsValid);
	}
}
