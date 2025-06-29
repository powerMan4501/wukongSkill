using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneSliceOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMeshPlaneSliceOptions
{
	private static bool FillHoles_IsValid;

	private static FFieldAddress FillHoles_PropertyAddress;

	private static int FillHoles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneSliceOptions:bFillHoles")]
	public bool FillHoles;

	private static bool FillSpans_IsValid;

	private static FFieldAddress FillSpans_PropertyAddress;

	private static int FillSpans_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneSliceOptions:bFillSpans")]
	public bool FillSpans;

	private static bool GapWidth_IsValid;

	private static int GapWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneSliceOptions:GapWidth")]
	public float GapWidth;

	private static bool UVWorldDimension_IsValid;

	private static int UVWorldDimension_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneSliceOptions:UVWorldDimension")]
	public float UVWorldDimension;

	private static bool FGeometryScriptMeshPlaneSliceOptions_IsValid;

	private static int FGeometryScriptMeshPlaneSliceOptions_StructSize;

	public FGeometryScriptMeshPlaneSliceOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptMeshPlaneSliceOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMeshPlaneSliceOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMeshPlaneSliceOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMeshPlaneSliceOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMeshPlaneSliceOptions(nativeBuffer + arrayIndex * FGeometryScriptMeshPlaneSliceOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMeshPlaneSliceOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMeshPlaneSliceOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshPlaneSliceOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneSliceOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FillHoles_Offset), 0, FillHoles_PropertyAddress.Address, FillHoles);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FillSpans_Offset), 0, FillSpans_PropertyAddress.Address, FillSpans);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GapWidth_Offset), GapWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, UVWorldDimension_Offset), UVWorldDimension);
	}

	public FGeometryScriptMeshPlaneSliceOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshPlaneSliceOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneSliceOptions");
			FillHoles = false;
			FillSpans = false;
			GapWidth = 0f;
			UVWorldDimension = 0f;
		}
		else
		{
			FillHoles = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FillHoles_Offset), 0, FillHoles_PropertyAddress.Address);
			FillSpans = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FillSpans_Offset), 0, FillSpans_PropertyAddress.Address);
			GapWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GapWidth_Offset));
			UVWorldDimension = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, UVWorldDimension_Offset));
		}
	}

	static FGeometryScriptMeshPlaneSliceOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMeshPlaneSliceOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMeshPlaneSliceOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneSliceOptions");
		FGeometryScriptMeshPlaneSliceOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FillHoles_PropertyAddress, intPtr, "bFillHoles");
		FillHoles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFillHoles");
		FillHoles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFillHoles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FillSpans_PropertyAddress, intPtr, "bFillSpans");
		FillSpans_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFillSpans");
		FillSpans_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFillSpans", Classes.FBoolProperty);
		GapWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GapWidth");
		GapWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GapWidth", Classes.FFloatProperty);
		UVWorldDimension_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVWorldDimension");
		UVWorldDimension_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVWorldDimension", Classes.FFloatProperty);
		FGeometryScriptMeshPlaneSliceOptions_IsValid = intPtr != IntPtr.Zero && FillHoles_IsValid && FillSpans_IsValid && GapWidth_IsValid && UVWorldDimension_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneSliceOptions", FGeometryScriptMeshPlaneSliceOptions_IsValid);
	}
}
