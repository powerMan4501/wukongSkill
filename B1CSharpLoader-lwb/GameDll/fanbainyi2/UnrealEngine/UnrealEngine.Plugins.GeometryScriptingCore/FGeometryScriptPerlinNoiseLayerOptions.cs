using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseLayerOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptPerlinNoiseLayerOptions
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseLayerOptions:Magnitude")]
	public float Magnitude;

	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseLayerOptions:Frequency")]
	public float Frequency;

	private static bool FrequencyShift_IsValid;

	private static int FrequencyShift_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseLayerOptions:FrequencyShift")]
	public FVector FrequencyShift;

	private static bool RandomSeed_IsValid;

	private static int RandomSeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseLayerOptions:RandomSeed")]
	public int RandomSeed;

	private static bool FGeometryScriptPerlinNoiseLayerOptions_IsValid;

	private static int FGeometryScriptPerlinNoiseLayerOptions_StructSize;

	public FGeometryScriptPerlinNoiseLayerOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptPerlinNoiseLayerOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptPerlinNoiseLayerOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptPerlinNoiseLayerOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptPerlinNoiseLayerOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptPerlinNoiseLayerOptions(nativeBuffer + arrayIndex * FGeometryScriptPerlinNoiseLayerOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptPerlinNoiseLayerOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptPerlinNoiseLayerOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPerlinNoiseLayerOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseLayerOptions");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Magnitude_Offset), Magnitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Frequency_Offset), Frequency);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, FrequencyShift_Offset), FrequencyShift);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RandomSeed_Offset), RandomSeed);
	}

	public FGeometryScriptPerlinNoiseLayerOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPerlinNoiseLayerOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseLayerOptions");
			Magnitude = 0f;
			Frequency = 0f;
			FrequencyShift = default(FVector);
			RandomSeed = 0;
		}
		else
		{
			Magnitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Magnitude_Offset));
			Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Frequency_Offset));
			FrequencyShift = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, FrequencyShift_Offset));
			RandomSeed = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RandomSeed_Offset));
		}
	}

	static FGeometryScriptPerlinNoiseLayerOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptPerlinNoiseLayerOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptPerlinNoiseLayerOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseLayerOptions");
		FGeometryScriptPerlinNoiseLayerOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		FrequencyShift_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrequencyShift");
		FrequencyShift_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrequencyShift", Classes.FStructProperty);
		RandomSeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RandomSeed");
		RandomSeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RandomSeed", Classes.FIntProperty);
		FGeometryScriptPerlinNoiseLayerOptions_IsValid = intPtr != IntPtr.Zero && Magnitude_IsValid && Frequency_IsValid && FrequencyShift_IsValid && RandomSeed_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptPerlinNoiseLayerOptions", FGeometryScriptPerlinNoiseLayerOptions_IsValid);
	}
}
