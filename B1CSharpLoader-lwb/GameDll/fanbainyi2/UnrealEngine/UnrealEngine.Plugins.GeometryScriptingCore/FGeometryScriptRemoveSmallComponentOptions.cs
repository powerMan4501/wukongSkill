using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveSmallComponentOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptRemoveSmallComponentOptions
{
	private static bool MinVolume_IsValid;

	private static int MinVolume_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveSmallComponentOptions:MinVolume")]
	public float MinVolume;

	private static bool MinArea_IsValid;

	private static int MinArea_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveSmallComponentOptions:MinArea")]
	public float MinArea;

	private static bool MinTriangleCount_IsValid;

	private static int MinTriangleCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveSmallComponentOptions:MinTriangleCount")]
	public int MinTriangleCount;

	private static bool FGeometryScriptRemoveSmallComponentOptions_IsValid;

	private static int FGeometryScriptRemoveSmallComponentOptions_StructSize;

	public FGeometryScriptRemoveSmallComponentOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptRemoveSmallComponentOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptRemoveSmallComponentOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptRemoveSmallComponentOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptRemoveSmallComponentOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptRemoveSmallComponentOptions(nativeBuffer + arrayIndex * FGeometryScriptRemoveSmallComponentOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptRemoveSmallComponentOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptRemoveSmallComponentOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRemoveSmallComponentOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRemoveSmallComponentOptions");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinVolume_Offset), MinVolume);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinArea_Offset), MinArea);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MinTriangleCount_Offset), MinTriangleCount);
	}

	public FGeometryScriptRemoveSmallComponentOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRemoveSmallComponentOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRemoveSmallComponentOptions");
			MinVolume = 0f;
			MinArea = 0f;
			MinTriangleCount = 0;
		}
		else
		{
			MinVolume = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinVolume_Offset));
			MinArea = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinArea_Offset));
			MinTriangleCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MinTriangleCount_Offset));
		}
	}

	static FGeometryScriptRemoveSmallComponentOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptRemoveSmallComponentOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptRemoveSmallComponentOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptRemoveSmallComponentOptions");
		FGeometryScriptRemoveSmallComponentOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		MinVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinVolume");
		MinVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinVolume", Classes.FFloatProperty);
		MinArea_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinArea");
		MinArea_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinArea", Classes.FFloatProperty);
		MinTriangleCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinTriangleCount");
		MinTriangleCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinTriangleCount", Classes.FIntProperty);
		FGeometryScriptRemoveSmallComponentOptions_IsValid = intPtr != IntPtr.Zero && MinVolume_IsValid && MinArea_IsValid && MinTriangleCount_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptRemoveSmallComponentOptions", FGeometryScriptRemoveSmallComponentOptions_IsValid);
	}
}
