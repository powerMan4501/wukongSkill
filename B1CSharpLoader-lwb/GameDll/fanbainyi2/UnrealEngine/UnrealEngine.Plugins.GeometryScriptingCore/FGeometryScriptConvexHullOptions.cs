using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptConvexHullOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptConvexHullOptions
{
	private static bool PrefilterVertices_IsValid;

	private static FFieldAddress PrefilterVertices_PropertyAddress;

	private static int PrefilterVertices_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptConvexHullOptions:bPrefilterVertices")]
	public bool PrefilterVertices;

	private static bool PrefilterGridResolution_IsValid;

	private static int PrefilterGridResolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptConvexHullOptions:PrefilterGridResolution")]
	public int PrefilterGridResolution;

	private static bool SimplifyToFaceCount_IsValid;

	private static int SimplifyToFaceCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptConvexHullOptions:SimplifyToFaceCount")]
	public int SimplifyToFaceCount;

	private static bool FGeometryScriptConvexHullOptions_IsValid;

	private static int FGeometryScriptConvexHullOptions_StructSize;

	public FGeometryScriptConvexHullOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptConvexHullOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptConvexHullOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptConvexHullOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptConvexHullOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptConvexHullOptions(nativeBuffer + arrayIndex * FGeometryScriptConvexHullOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptConvexHullOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptConvexHullOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptConvexHullOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptConvexHullOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, PrefilterVertices_Offset), 0, PrefilterVertices_PropertyAddress.Address, PrefilterVertices);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PrefilterGridResolution_Offset), PrefilterGridResolution);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SimplifyToFaceCount_Offset), SimplifyToFaceCount);
	}

	public FGeometryScriptConvexHullOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptConvexHullOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptConvexHullOptions");
			PrefilterVertices = false;
			PrefilterGridResolution = 0;
			SimplifyToFaceCount = 0;
		}
		else
		{
			PrefilterVertices = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, PrefilterVertices_Offset), 0, PrefilterVertices_PropertyAddress.Address);
			PrefilterGridResolution = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PrefilterGridResolution_Offset));
			SimplifyToFaceCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SimplifyToFaceCount_Offset));
		}
	}

	static FGeometryScriptConvexHullOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptConvexHullOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptConvexHullOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptConvexHullOptions");
		FGeometryScriptConvexHullOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PrefilterVertices_PropertyAddress, intPtr, "bPrefilterVertices");
		PrefilterVertices_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPrefilterVertices");
		PrefilterVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPrefilterVertices", Classes.FBoolProperty);
		PrefilterGridResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PrefilterGridResolution");
		PrefilterGridResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PrefilterGridResolution", Classes.FIntProperty);
		SimplifyToFaceCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimplifyToFaceCount");
		SimplifyToFaceCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimplifyToFaceCount", Classes.FIntProperty);
		FGeometryScriptConvexHullOptions_IsValid = intPtr != IntPtr.Zero && PrefilterVertices_IsValid && PrefilterGridResolution_IsValid && SimplifyToFaceCount_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptConvexHullOptions", FGeometryScriptConvexHullOptions_IsValid);
	}
}
