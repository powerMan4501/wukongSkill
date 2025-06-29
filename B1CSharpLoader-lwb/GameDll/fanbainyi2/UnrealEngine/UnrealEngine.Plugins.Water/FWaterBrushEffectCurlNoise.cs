using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.WaterBrushEffectCurlNoise", "Water", UnrealModuleType.EnginePlugin)]
public struct FWaterBrushEffectCurlNoise
{
	private static bool Curl1Amount_IsValid;

	private static int Curl1Amount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectCurlNoise:Curl1Amount")]
	public float Curl1Amount;

	private static bool Curl2Amount_IsValid;

	private static int Curl2Amount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectCurlNoise:Curl2Amount")]
	public float Curl2Amount;

	private static bool Curl1Tiling_IsValid;

	private static int Curl1Tiling_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectCurlNoise:Curl1Tiling")]
	public float Curl1Tiling;

	private static bool Curl2Tiling_IsValid;

	private static int Curl2Tiling_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectCurlNoise:Curl2Tiling")]
	public float Curl2Tiling;

	private static bool FWaterBrushEffectCurlNoise_IsValid;

	private static int FWaterBrushEffectCurlNoise_StructSize;

	public FWaterBrushEffectCurlNoise Copy()
	{
		return this;
	}

	public static FWaterBrushEffectCurlNoise FromNative(IntPtr nativeBuffer)
	{
		return new FWaterBrushEffectCurlNoise(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterBrushEffectCurlNoise value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterBrushEffectCurlNoise FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterBrushEffectCurlNoise(nativeBuffer + arrayIndex * FWaterBrushEffectCurlNoise_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterBrushEffectCurlNoise value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWaterBrushEffectCurlNoise_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffectCurlNoise_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffectCurlNoise");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Curl1Amount_Offset), Curl1Amount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Curl2Amount_Offset), Curl2Amount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Curl1Tiling_Offset), Curl1Tiling);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Curl2Tiling_Offset), Curl2Tiling);
	}

	public FWaterBrushEffectCurlNoise(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffectCurlNoise_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffectCurlNoise");
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

	static FWaterBrushEffectCurlNoise()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWaterBrushEffectCurlNoise)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterBrushEffectCurlNoise));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.WaterBrushEffectCurlNoise");
		FWaterBrushEffectCurlNoise_StructSize = NativeReflection.GetStructSize(intPtr);
		Curl1Amount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Curl1Amount");
		Curl1Amount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Curl1Amount", Classes.FFloatProperty);
		Curl2Amount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Curl2Amount");
		Curl2Amount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Curl2Amount", Classes.FFloatProperty);
		Curl1Tiling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Curl1Tiling");
		Curl1Tiling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Curl1Tiling", Classes.FFloatProperty);
		Curl2Tiling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Curl2Tiling");
		Curl2Tiling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Curl2Tiling", Classes.FFloatProperty);
		FWaterBrushEffectCurlNoise_IsValid = intPtr != IntPtr.Zero && Curl1Amount_IsValid && Curl2Amount_IsValid && Curl1Tiling_IsValid && Curl2Tiling_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.WaterBrushEffectCurlNoise", FWaterBrushEffectCurlNoise_IsValid);
	}
}
