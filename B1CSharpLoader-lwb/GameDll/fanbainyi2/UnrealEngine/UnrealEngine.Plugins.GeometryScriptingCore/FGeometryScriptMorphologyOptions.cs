using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMorphologyOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMorphologyOptions
{
	private static bool SDFGridParameters_IsValid;

	private static int SDFGridParameters_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMorphologyOptions:SDFGridParameters")]
	public FGeometryScript3DGridParameters SDFGridParameters;

	private static bool UseSeparateMeshGrid_IsValid;

	private static FFieldAddress UseSeparateMeshGrid_PropertyAddress;

	private static int UseSeparateMeshGrid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMorphologyOptions:bUseSeparateMeshGrid")]
	public bool UseSeparateMeshGrid;

	private static bool MeshGridParameters_IsValid;

	private static int MeshGridParameters_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMorphologyOptions:MeshGridParameters")]
	public FGeometryScript3DGridParameters MeshGridParameters;

	private static bool Operation_IsValid;

	private static FFieldAddress Operation_PropertyAddress;

	private static int Operation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMorphologyOptions:Operation")]
	public EGeometryScriptMorphologicalOpType Operation;

	private static bool Distance_IsValid;

	private static int Distance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMorphologyOptions:Distance")]
	public float Distance;

	private static bool FGeometryScriptMorphologyOptions_IsValid;

	private static int FGeometryScriptMorphologyOptions_StructSize;

	public FGeometryScriptMorphologyOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptMorphologyOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMorphologyOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMorphologyOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMorphologyOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMorphologyOptions(nativeBuffer + arrayIndex * FGeometryScriptMorphologyOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMorphologyOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMorphologyOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMorphologyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMorphologyOptions");
			return;
		}
		FGeometryScript3DGridParameters.ToNative(IntPtr.Add(nativeStruct, SDFGridParameters_Offset), SDFGridParameters);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseSeparateMeshGrid_Offset), 0, UseSeparateMeshGrid_PropertyAddress.Address, UseSeparateMeshGrid);
		FGeometryScript3DGridParameters.ToNative(IntPtr.Add(nativeStruct, MeshGridParameters_Offset), MeshGridParameters);
		EnumMarshaler<EGeometryScriptMorphologicalOpType>.ToNative(IntPtr.Add(nativeStruct, Operation_Offset), 0, Operation_PropertyAddress.Address, Operation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Distance_Offset), Distance);
	}

	public FGeometryScriptMorphologyOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMorphologyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMorphologyOptions");
			SDFGridParameters = default(FGeometryScript3DGridParameters);
			UseSeparateMeshGrid = false;
			MeshGridParameters = default(FGeometryScript3DGridParameters);
			Operation = EGeometryScriptMorphologicalOpType.Dilate;
			Distance = 0f;
		}
		else
		{
			SDFGridParameters = FGeometryScript3DGridParameters.FromNative(IntPtr.Add(nativeStruct, SDFGridParameters_Offset));
			UseSeparateMeshGrid = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseSeparateMeshGrid_Offset), 0, UseSeparateMeshGrid_PropertyAddress.Address);
			MeshGridParameters = FGeometryScript3DGridParameters.FromNative(IntPtr.Add(nativeStruct, MeshGridParameters_Offset));
			Operation = EnumMarshaler<EGeometryScriptMorphologicalOpType>.FromNative(IntPtr.Add(nativeStruct, Operation_Offset), 0, Operation_PropertyAddress.Address);
			Distance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Distance_Offset));
		}
	}

	static FGeometryScriptMorphologyOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMorphologyOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMorphologyOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMorphologyOptions");
		FGeometryScriptMorphologyOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		SDFGridParameters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SDFGridParameters");
		SDFGridParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SDFGridParameters", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseSeparateMeshGrid_PropertyAddress, intPtr, "bUseSeparateMeshGrid");
		UseSeparateMeshGrid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseSeparateMeshGrid");
		UseSeparateMeshGrid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseSeparateMeshGrid", Classes.FBoolProperty);
		MeshGridParameters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshGridParameters");
		MeshGridParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshGridParameters", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Operation_PropertyAddress, intPtr, "Operation");
		Operation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Operation");
		Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Operation", Classes.FEnumProperty);
		Distance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Distance");
		Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Distance", Classes.FFloatProperty);
		FGeometryScriptMorphologyOptions_IsValid = intPtr != IntPtr.Zero && SDFGridParameters_IsValid && UseSeparateMeshGrid_IsValid && MeshGridParameters_IsValid && Operation_IsValid && Distance_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMorphologyOptions", FGeometryScriptMorphologyOptions_IsValid);
	}
}
