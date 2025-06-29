using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/DataprepLibraries.DataprepSetLODsReductionSettings", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public struct FDataprepSetLODsReductionSettings
{
	private static bool PercentTriangles_IsValid;

	private static int PercentTriangles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetLODsReductionSettings:PercentTriangles")]
	public float PercentTriangles;

	private static bool ScreenSize_IsValid;

	private static int ScreenSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetLODsReductionSettings:ScreenSize")]
	public float ScreenSize;

	private static bool FDataprepSetLODsReductionSettings_IsValid;

	private static int FDataprepSetLODsReductionSettings_StructSize;

	public FDataprepSetLODsReductionSettings Copy()
	{
		return this;
	}

	public static FDataprepSetLODsReductionSettings FromNative(IntPtr nativeBuffer)
	{
		return new FDataprepSetLODsReductionSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDataprepSetLODsReductionSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDataprepSetLODsReductionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDataprepSetLODsReductionSettings(nativeBuffer + arrayIndex * FDataprepSetLODsReductionSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDataprepSetLODsReductionSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDataprepSetLODsReductionSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDataprepSetLODsReductionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepLibraries.DataprepSetLODsReductionSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PercentTriangles_Offset), PercentTriangles);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScreenSize_Offset), ScreenSize);
	}

	public FDataprepSetLODsReductionSettings(IntPtr nativeStruct)
	{
		if (!FDataprepSetLODsReductionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepLibraries.DataprepSetLODsReductionSettings");
			PercentTriangles = 0f;
			ScreenSize = 0f;
		}
		else
		{
			PercentTriangles = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PercentTriangles_Offset));
			ScreenSize = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScreenSize_Offset));
		}
	}

	static FDataprepSetLODsReductionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDataprepSetLODsReductionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDataprepSetLODsReductionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DataprepLibraries.DataprepSetLODsReductionSettings");
		FDataprepSetLODsReductionSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		PercentTriangles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PercentTriangles");
		PercentTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PercentTriangles", Classes.FFloatProperty);
		ScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScreenSize");
		ScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScreenSize", Classes.FFloatProperty);
		FDataprepSetLODsReductionSettings_IsValid = intPtr != IntPtr.Zero && PercentTriangles_IsValid && ScreenSize_IsValid;
		NativeReflection.LogStructIsValid("/Script/DataprepLibraries.DataprepSetLODsReductionSettings", FDataprepSetLODsReductionSettings_IsValid);
	}
}
