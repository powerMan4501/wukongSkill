using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Landmass;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Landmass.LandmassBrushEffectsList", "Landmass", UnrealModuleType.EnginePlugin)]
public struct FLandmassBrushEffectsList
{
	private static bool Blurring_IsValid;

	private static int Blurring_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Landmass.LandmassBrushEffectsList:Blurring")]
	public FBrushEffectBlurring Blurring;

	private static bool CurlNoise_IsValid;

	private static int CurlNoise_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Landmass.LandmassBrushEffectsList:CurlNoise")]
	public FBrushEffectCurlNoise CurlNoise;

	private static bool Displacement_IsValid;

	private static int Displacement_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Landmass.LandmassBrushEffectsList:Displacement")]
	public FBrushEffectDisplacement Displacement;

	private static bool SmoothBlending_IsValid;

	private static int SmoothBlending_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Landmass.LandmassBrushEffectsList:SmoothBlending")]
	public FBrushEffectSmoothBlending SmoothBlending;

	private static bool Terracing_IsValid;

	private static int Terracing_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Landmass.LandmassBrushEffectsList:Terracing")]
	public FBrushEffectTerracing Terracing;

	private static bool FLandmassBrushEffectsList_IsValid;

	private static int FLandmassBrushEffectsList_StructSize;

	public FLandmassBrushEffectsList Copy()
	{
		return this;
	}

	public static FLandmassBrushEffectsList FromNative(IntPtr nativeBuffer)
	{
		return new FLandmassBrushEffectsList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLandmassBrushEffectsList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLandmassBrushEffectsList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLandmassBrushEffectsList(nativeBuffer + arrayIndex * FLandmassBrushEffectsList_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLandmassBrushEffectsList value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLandmassBrushEffectsList_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLandmassBrushEffectsList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.LandmassBrushEffectsList");
			return;
		}
		FBrushEffectBlurring.ToNative(IntPtr.Add(nativeStruct, Blurring_Offset), Blurring);
		FBrushEffectCurlNoise.ToNative(IntPtr.Add(nativeStruct, CurlNoise_Offset), CurlNoise);
		FBrushEffectDisplacement.ToNative(IntPtr.Add(nativeStruct, Displacement_Offset), Displacement);
		FBrushEffectSmoothBlending.ToNative(IntPtr.Add(nativeStruct, SmoothBlending_Offset), SmoothBlending);
		FBrushEffectTerracing.ToNative(IntPtr.Add(nativeStruct, Terracing_Offset), Terracing);
	}

	public FLandmassBrushEffectsList(IntPtr nativeStruct)
	{
		if (!FLandmassBrushEffectsList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.LandmassBrushEffectsList");
			Blurring = default(FBrushEffectBlurring);
			CurlNoise = default(FBrushEffectCurlNoise);
			Displacement = default(FBrushEffectDisplacement);
			SmoothBlending = default(FBrushEffectSmoothBlending);
			Terracing = default(FBrushEffectTerracing);
		}
		else
		{
			Blurring = FBrushEffectBlurring.FromNative(IntPtr.Add(nativeStruct, Blurring_Offset));
			CurlNoise = FBrushEffectCurlNoise.FromNative(IntPtr.Add(nativeStruct, CurlNoise_Offset));
			Displacement = FBrushEffectDisplacement.FromNative(IntPtr.Add(nativeStruct, Displacement_Offset));
			SmoothBlending = FBrushEffectSmoothBlending.FromNative(IntPtr.Add(nativeStruct, SmoothBlending_Offset));
			Terracing = FBrushEffectTerracing.FromNative(IntPtr.Add(nativeStruct, Terracing_Offset));
		}
	}

	static FLandmassBrushEffectsList()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLandmassBrushEffectsList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLandmassBrushEffectsList));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Landmass.LandmassBrushEffectsList");
		FLandmassBrushEffectsList_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FLandmassBrushEffectsList_IsValid = intPtr != IntPtr.Zero && Blurring_IsValid && CurlNoise_IsValid && Displacement_IsValid && SmoothBlending_IsValid && Terracing_IsValid;
		NativeReflection.LogStructIsValid("/Script/Landmass.LandmassBrushEffectsList", FLandmassBrushEffectsList_IsValid);
	}
}
