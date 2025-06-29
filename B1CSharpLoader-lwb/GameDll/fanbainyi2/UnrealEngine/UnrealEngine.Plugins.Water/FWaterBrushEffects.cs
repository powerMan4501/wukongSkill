using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.WaterBrushEffects", "Water", UnrealModuleType.EnginePlugin)]
public struct FWaterBrushEffects
{
	private static bool Blurring_IsValid;

	private static int Blurring_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Water.WaterBrushEffects:Blurring")]
	public FWaterBrushEffectBlurring Blurring;

	private static bool CurlNoise_IsValid;

	private static int CurlNoise_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Water.WaterBrushEffects:CurlNoise")]
	public FWaterBrushEffectCurlNoise CurlNoise;

	private static bool Displacement_IsValid;

	private static int Displacement_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Water.WaterBrushEffects:Displacement")]
	public FWaterBrushEffectDisplacement Displacement;

	private static bool SmoothBlending_IsValid;

	private static int SmoothBlending_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Water.WaterBrushEffects:SmoothBlending")]
	public FWaterBrushEffectSmoothBlending SmoothBlending;

	private static bool Terracing_IsValid;

	private static int Terracing_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Water.WaterBrushEffects:Terracing")]
	public FWaterBrushEffectTerracing Terracing;

	private static bool FWaterBrushEffects_IsValid;

	private static int FWaterBrushEffects_StructSize;

	public FWaterBrushEffects Copy()
	{
		return this;
	}

	public static FWaterBrushEffects FromNative(IntPtr nativeBuffer)
	{
		return new FWaterBrushEffects(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterBrushEffects value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterBrushEffects FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterBrushEffects(nativeBuffer + arrayIndex * FWaterBrushEffects_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterBrushEffects value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWaterBrushEffects_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffects_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffects");
			return;
		}
		FWaterBrushEffectBlurring.ToNative(IntPtr.Add(nativeStruct, Blurring_Offset), Blurring);
		FWaterBrushEffectCurlNoise.ToNative(IntPtr.Add(nativeStruct, CurlNoise_Offset), CurlNoise);
		FWaterBrushEffectDisplacement.ToNative(IntPtr.Add(nativeStruct, Displacement_Offset), Displacement);
		FWaterBrushEffectSmoothBlending.ToNative(IntPtr.Add(nativeStruct, SmoothBlending_Offset), SmoothBlending);
		FWaterBrushEffectTerracing.ToNative(IntPtr.Add(nativeStruct, Terracing_Offset), Terracing);
	}

	public FWaterBrushEffects(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffects_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffects");
			Blurring = default(FWaterBrushEffectBlurring);
			CurlNoise = default(FWaterBrushEffectCurlNoise);
			Displacement = default(FWaterBrushEffectDisplacement);
			SmoothBlending = default(FWaterBrushEffectSmoothBlending);
			Terracing = default(FWaterBrushEffectTerracing);
		}
		else
		{
			Blurring = FWaterBrushEffectBlurring.FromNative(IntPtr.Add(nativeStruct, Blurring_Offset));
			CurlNoise = FWaterBrushEffectCurlNoise.FromNative(IntPtr.Add(nativeStruct, CurlNoise_Offset));
			Displacement = FWaterBrushEffectDisplacement.FromNative(IntPtr.Add(nativeStruct, Displacement_Offset));
			SmoothBlending = FWaterBrushEffectSmoothBlending.FromNative(IntPtr.Add(nativeStruct, SmoothBlending_Offset));
			Terracing = FWaterBrushEffectTerracing.FromNative(IntPtr.Add(nativeStruct, Terracing_Offset));
		}
	}

	static FWaterBrushEffects()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWaterBrushEffects)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterBrushEffects));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.WaterBrushEffects");
		FWaterBrushEffects_StructSize = NativeReflection.GetStructSize(intPtr);
		Blurring_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Blurring");
		Blurring_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Blurring", Classes.FStructProperty);
		CurlNoise_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurlNoise");
		CurlNoise_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurlNoise", Classes.FStructProperty);
		Displacement_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Displacement");
		Displacement_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Displacement", Classes.FStructProperty);
		SmoothBlending_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SmoothBlending");
		SmoothBlending_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SmoothBlending", Classes.FStructProperty);
		Terracing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Terracing");
		Terracing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Terracing", Classes.FStructProperty);
		FWaterBrushEffects_IsValid = intPtr != IntPtr.Zero && Blurring_IsValid && CurlNoise_IsValid && Displacement_IsValid && SmoothBlending_IsValid && Terracing_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.WaterBrushEffects", FWaterBrushEffects_IsValid);
	}
}
