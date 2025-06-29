using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Landmass;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Landmass.BrushEffectCurlNoise", "Landmass", UnrealModuleType.EnginePlugin)]
public struct FBrushEffectCurlNoise
{
	private static bool Curl1Amount_IsValid;

	private static int Curl1Amount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectCurlNoise:Curl1Amount")]
	public float Curl1Amount;

	private static bool Curl2Amount_IsValid;

	private static int Curl2Amount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectCurlNoise:Curl2Amount")]
	public float Curl2Amount;

	private static bool Curl1Tiling_IsValid;

	private static int Curl1Tiling_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectCurlNoise:Curl1Tiling")]
	public float Curl1Tiling;

	private static bool Curl2Tiling_IsValid;

	private static int Curl2Tiling_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectCurlNoise:Curl2Tiling")]
	public float Curl2Tiling;

	private static bool FBrushEffectCurlNoise_IsValid;

	private static int FBrushEffectCurlNoise_StructSize;

	public FBrushEffectCurlNoise Copy()
	{
		return this;
	}

	public static FBrushEffectCurlNoise FromNative(IntPtr nativeBuffer)
	{
		return new FBrushEffectCurlNoise(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBrushEffectCurlNoise value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBrushEffectCurlNoise FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBrushEffectCurlNoise(nativeBuffer + arrayIndex * FBrushEffectCurlNoise_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBrushEffectCurlNoise value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBrushEffectCurlNoise_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBrushEffectCurlNoise_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectCurlNoise");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Curl1Amount_Offset), Curl1Amount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Curl2Amount_Offset), Curl2Amount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Curl1Tiling_Offset), Curl1Tiling);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Curl2Tiling_Offset), Curl2Tiling);
	}

	public FBrushEffectCurlNoise(IntPtr nativeStruct)
	{
		if (!FBrushEffectCurlNoise_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectCurlNoise");
			Curl1Amount = 0f;
			Curl2Amount = 0f;
			Curl1Tiling = 0f;
			Curl2Tiling = 0f;
		}
		else
		{
			Curl1Amount = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Curl1Amount_Offset));
			Curl2Amount = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Curl2Amount_Offset));
			Curl1Tiling = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Curl1Tiling_Offset));
			Curl2Tiling = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Curl2Tiling_Offset));
		}
	}

	static FBrushEffectCurlNoise()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBrushEffectCurlNoise)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBrushEffectCurlNoise));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Landmass.BrushEffectCurlNoise");
		FBrushEffectCurlNoise_StructSize = NativeReflection.GetStructSize(intPtr);
		Curl1Amount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Curl1Amount");
		Curl1Amount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Curl1Amount", Classes.FFloatProperty);
		Curl2Amount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Curl2Amount");
		Curl2Amount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Curl2Amount", Classes.FFloatProperty);
		Curl1Tiling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Curl1Tiling");
		Curl1Tiling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Curl1Tiling", Classes.FFloatProperty);
		Curl2Tiling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Curl2Tiling");
		Curl2Tiling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Curl2Tiling", Classes.FFloatProperty);
		FBrushEffectCurlNoise_IsValid = intPtr != IntPtr.Zero && Curl1Amount_IsValid && Curl2Amount_IsValid && Curl1Tiling_IsValid && Curl2Tiling_IsValid;
		NativeReflection.LogStructIsValid("/Script/Landmass.BrushEffectCurlNoise", FBrushEffectCurlNoise_IsValid);
	}
}
