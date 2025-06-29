using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSweptHullOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptSweptHullOptions
{
	private static bool PrefilterVertices_IsValid;

	private static FFieldAddress PrefilterVertices_PropertyAddress;

	private static int PrefilterVertices_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSweptHullOptions:bPrefilterVertices")]
	public bool PrefilterVertices;

	private static bool PrefilterGridResolution_IsValid;

	private static int PrefilterGridResolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSweptHullOptions:PrefilterGridResolution")]
	public int PrefilterGridResolution;

	private static bool MinThickness_IsValid;

	private static int MinThickness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSweptHullOptions:MinThickness")]
	public float MinThickness;

	private static bool Simplify_IsValid;

	private static FFieldAddress Simplify_PropertyAddress;

	private static int Simplify_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSweptHullOptions:bSimplify")]
	public bool Simplify;

	private static bool MinEdgeLength_IsValid;

	private static int MinEdgeLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSweptHullOptions:MinEdgeLength")]
	public float MinEdgeLength;

	private static bool SimplifyTolerance_IsValid;

	private static int SimplifyTolerance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSweptHullOptions:SimplifyTolerance")]
	public float SimplifyTolerance;

	private static bool FGeometryScriptSweptHullOptions_IsValid;

	private static int FGeometryScriptSweptHullOptions_StructSize;

	public FGeometryScriptSweptHullOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptSweptHullOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptSweptHullOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptSweptHullOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptSweptHullOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptSweptHullOptions(nativeBuffer + arrayIndex * FGeometryScriptSweptHullOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptSweptHullOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptSweptHullOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSweptHullOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSweptHullOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, PrefilterVertices_Offset), 0, PrefilterVertices_PropertyAddress.Address, PrefilterVertices);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PrefilterGridResolution_Offset), PrefilterGridResolution);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinThickness_Offset), MinThickness);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Simplify_Offset), 0, Simplify_PropertyAddress.Address, Simplify);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinEdgeLength_Offset), MinEdgeLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SimplifyTolerance_Offset), SimplifyTolerance);
	}

	public FGeometryScriptSweptHullOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSweptHullOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSweptHullOptions");
			PrefilterVertices = false;
			PrefilterGridResolution = 0;
			MinThickness = 0f;
			Simplify = false;
			MinEdgeLength = 0f;
			SimplifyTolerance = 0f;
		}
		else
		{
			PrefilterVertices = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, PrefilterVertices_Offset), 0, PrefilterVertices_PropertyAddress.Address);
			PrefilterGridResolution = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PrefilterGridResolution_Offset));
			MinThickness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinThickness_Offset));
			Simplify = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Simplify_Offset), 0, Simplify_PropertyAddress.Address);
			MinEdgeLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinEdgeLength_Offset));
			SimplifyTolerance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SimplifyTolerance_Offset));
		}
	}

	static FGeometryScriptSweptHullOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptSweptHullOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptSweptHullOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptSweptHullOptions");
		FGeometryScriptSweptHullOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PrefilterVertices_PropertyAddress, intPtr, "bPrefilterVertices");
		PrefilterVertices_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPrefilterVertices");
		PrefilterVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPrefilterVertices", Classes.FBoolProperty);
		PrefilterGridResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PrefilterGridResolution");
		PrefilterGridResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PrefilterGridResolution", Classes.FIntProperty);
		MinThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinThickness");
		MinThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinThickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Simplify_PropertyAddress, intPtr, "bSimplify");
		Simplify_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSimplify");
		Simplify_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSimplify", Classes.FBoolProperty);
		MinEdgeLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinEdgeLength");
		MinEdgeLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinEdgeLength", Classes.FFloatProperty);
		SimplifyTolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimplifyTolerance");
		SimplifyTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimplifyTolerance", Classes.FFloatProperty);
		FGeometryScriptSweptHullOptions_IsValid = intPtr != IntPtr.Zero && PrefilterVertices_IsValid && PrefilterGridResolution_IsValid && MinThickness_IsValid && Simplify_IsValid && MinEdgeLength_IsValid && SimplifyTolerance_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptSweptHullOptions", FGeometryScriptSweptHullOptions_IsValid);
	}
}
