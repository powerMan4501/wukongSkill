using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBooleanOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMeshBooleanOptions
{
	private static bool FillHoles_IsValid;

	private static FFieldAddress FillHoles_PropertyAddress;

	private static int FillHoles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBooleanOptions:bFillHoles")]
	public bool FillHoles;

	private static bool SimplifyOutput_IsValid;

	private static FFieldAddress SimplifyOutput_PropertyAddress;

	private static int SimplifyOutput_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBooleanOptions:bSimplifyOutput")]
	public bool SimplifyOutput;

	private static bool SimplifyPlanarTolerance_IsValid;

	private static int SimplifyPlanarTolerance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBooleanOptions:SimplifyPlanarTolerance")]
	public float SimplifyPlanarTolerance;

	private static bool FGeometryScriptMeshBooleanOptions_IsValid;

	private static int FGeometryScriptMeshBooleanOptions_StructSize;

	public FGeometryScriptMeshBooleanOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptMeshBooleanOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMeshBooleanOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMeshBooleanOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMeshBooleanOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMeshBooleanOptions(nativeBuffer + arrayIndex * FGeometryScriptMeshBooleanOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMeshBooleanOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMeshBooleanOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshBooleanOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshBooleanOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FillHoles_Offset), 0, FillHoles_PropertyAddress.Address, FillHoles);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SimplifyOutput_Offset), 0, SimplifyOutput_PropertyAddress.Address, SimplifyOutput);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SimplifyPlanarTolerance_Offset), SimplifyPlanarTolerance);
	}

	public FGeometryScriptMeshBooleanOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshBooleanOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshBooleanOptions");
			FillHoles = false;
			SimplifyOutput = false;
			SimplifyPlanarTolerance = 0f;
		}
		else
		{
			FillHoles = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FillHoles_Offset), 0, FillHoles_PropertyAddress.Address);
			SimplifyOutput = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SimplifyOutput_Offset), 0, SimplifyOutput_PropertyAddress.Address);
			SimplifyPlanarTolerance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SimplifyPlanarTolerance_Offset));
		}
	}

	static FGeometryScriptMeshBooleanOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMeshBooleanOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMeshBooleanOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMeshBooleanOptions");
		FGeometryScriptMeshBooleanOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FillHoles_PropertyAddress, intPtr, "bFillHoles");
		FillHoles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFillHoles");
		FillHoles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFillHoles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SimplifyOutput_PropertyAddress, intPtr, "bSimplifyOutput");
		SimplifyOutput_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSimplifyOutput");
		SimplifyOutput_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSimplifyOutput", Classes.FBoolProperty);
		SimplifyPlanarTolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimplifyPlanarTolerance");
		SimplifyPlanarTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimplifyPlanarTolerance", Classes.FFloatProperty);
		FGeometryScriptMeshBooleanOptions_IsValid = intPtr != IntPtr.Zero && FillHoles_IsValid && SimplifyOutput_IsValid && SimplifyPlanarTolerance_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMeshBooleanOptions", FGeometryScriptMeshBooleanOptions_IsValid);
	}
}
