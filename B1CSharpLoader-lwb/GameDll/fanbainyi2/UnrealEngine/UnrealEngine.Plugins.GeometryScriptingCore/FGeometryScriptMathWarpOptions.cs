using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMathWarpOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMathWarpOptions
{
	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMathWarpOptions:Magnitude")]
	public float Magnitude;

	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMathWarpOptions:Frequency")]
	public float Frequency;

	private static bool FrequencyShift_IsValid;

	private static int FrequencyShift_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMathWarpOptions:FrequencyShift")]
	public float FrequencyShift;

	private static bool FGeometryScriptMathWarpOptions_IsValid;

	private static int FGeometryScriptMathWarpOptions_StructSize;

	public FGeometryScriptMathWarpOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptMathWarpOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMathWarpOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMathWarpOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMathWarpOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMathWarpOptions(nativeBuffer + arrayIndex * FGeometryScriptMathWarpOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMathWarpOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMathWarpOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMathWarpOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMathWarpOptions");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Magnitude_Offset), Magnitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Frequency_Offset), Frequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FrequencyShift_Offset), FrequencyShift);
	}

	public FGeometryScriptMathWarpOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMathWarpOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMathWarpOptions");
			Magnitude = 0f;
			Frequency = 0f;
			FrequencyShift = 0f;
		}
		else
		{
			Magnitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Magnitude_Offset));
			Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Frequency_Offset));
			FrequencyShift = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FrequencyShift_Offset));
		}
	}

	static FGeometryScriptMathWarpOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMathWarpOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMathWarpOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMathWarpOptions");
		FGeometryScriptMathWarpOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		FrequencyShift_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrequencyShift");
		FrequencyShift_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrequencyShift", Classes.FFloatProperty);
		FGeometryScriptMathWarpOptions_IsValid = intPtr != IntPtr.Zero && Magnitude_IsValid && Frequency_IsValid && FrequencyShift_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMathWarpOptions", FGeometryScriptMathWarpOptions_IsValid);
	}
}
