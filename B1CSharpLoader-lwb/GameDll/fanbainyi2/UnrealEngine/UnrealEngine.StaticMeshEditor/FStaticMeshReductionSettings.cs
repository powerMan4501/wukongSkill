using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.StaticMeshEditor;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/StaticMeshEditor.StaticMeshReductionSettings", "StaticMeshEditor", UnrealModuleType.Engine)]
public struct FStaticMeshReductionSettings
{
	private static bool PercentTriangles_IsValid;

	private static int PercentTriangles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshReductionSettings:PercentTriangles")]
	public float PercentTriangles;

	private static bool ScreenSize_IsValid;

	private static int ScreenSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshReductionSettings:ScreenSize")]
	public float ScreenSize;

	private static bool FStaticMeshReductionSettings_IsValid;

	private static int FStaticMeshReductionSettings_StructSize;

	public FStaticMeshReductionSettings Copy()
	{
		return this;
	}

	public static FStaticMeshReductionSettings FromNative(IntPtr nativeBuffer)
	{
		return new FStaticMeshReductionSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStaticMeshReductionSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStaticMeshReductionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStaticMeshReductionSettings(nativeBuffer + arrayIndex * FStaticMeshReductionSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStaticMeshReductionSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FStaticMeshReductionSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FStaticMeshReductionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StaticMeshEditor.StaticMeshReductionSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PercentTriangles_Offset), PercentTriangles);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScreenSize_Offset), ScreenSize);
	}

	public FStaticMeshReductionSettings(IntPtr nativeStruct)
	{
		if (!FStaticMeshReductionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StaticMeshEditor.StaticMeshReductionSettings");
			PercentTriangles = 0f;
			ScreenSize = 0f;
		}
		else
		{
			PercentTriangles = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PercentTriangles_Offset));
			ScreenSize = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScreenSize_Offset));
		}
	}

	static FStaticMeshReductionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FStaticMeshReductionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStaticMeshReductionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/StaticMeshEditor.StaticMeshReductionSettings");
		FStaticMeshReductionSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		PercentTriangles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PercentTriangles");
		PercentTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PercentTriangles", Classes.FFloatProperty);
		ScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScreenSize");
		ScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScreenSize", Classes.FFloatProperty);
		FStaticMeshReductionSettings_IsValid = intPtr != IntPtr.Zero && PercentTriangles_IsValid && ScreenSize_IsValid;
		NativeReflection.LogStructIsValid("/Script/StaticMeshEditor.StaticMeshReductionSettings", FStaticMeshReductionSettings_IsValid);
	}
}
