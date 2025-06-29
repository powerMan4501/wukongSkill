using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshSelfUnionOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMeshSelfUnionOptions
{
	private static bool FillHoles_IsValid;

	private static FFieldAddress FillHoles_PropertyAddress;

	private static int FillHoles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshSelfUnionOptions:bFillHoles")]
	public bool FillHoles;

	private static bool TrimFlaps_IsValid;

	private static FFieldAddress TrimFlaps_PropertyAddress;

	private static int TrimFlaps_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshSelfUnionOptions:bTrimFlaps")]
	public bool TrimFlaps;

	private static bool SimplifyOutput_IsValid;

	private static FFieldAddress SimplifyOutput_PropertyAddress;

	private static int SimplifyOutput_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshSelfUnionOptions:bSimplifyOutput")]
	public bool SimplifyOutput;

	private static bool SimplifyPlanarTolerance_IsValid;

	private static int SimplifyPlanarTolerance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshSelfUnionOptions:SimplifyPlanarTolerance")]
	public float SimplifyPlanarTolerance;

	private static bool WindingThreshold_IsValid;

	private static int WindingThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshSelfUnionOptions:WindingThreshold")]
	public float WindingThreshold;

	private static bool FGeometryScriptMeshSelfUnionOptions_IsValid;

	private static int FGeometryScriptMeshSelfUnionOptions_StructSize;

	public FGeometryScriptMeshSelfUnionOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptMeshSelfUnionOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMeshSelfUnionOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMeshSelfUnionOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMeshSelfUnionOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMeshSelfUnionOptions(nativeBuffer + arrayIndex * FGeometryScriptMeshSelfUnionOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMeshSelfUnionOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMeshSelfUnionOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshSelfUnionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshSelfUnionOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FillHoles_Offset), 0, FillHoles_PropertyAddress.Address, FillHoles);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, TrimFlaps_Offset), 0, TrimFlaps_PropertyAddress.Address, TrimFlaps);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SimplifyOutput_Offset), 0, SimplifyOutput_PropertyAddress.Address, SimplifyOutput);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SimplifyPlanarTolerance_Offset), SimplifyPlanarTolerance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WindingThreshold_Offset), WindingThreshold);
	}

	public FGeometryScriptMeshSelfUnionOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshSelfUnionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshSelfUnionOptions");
			FillHoles = false;
			TrimFlaps = false;
			SimplifyOutput = false;
			SimplifyPlanarTolerance = 0f;
			WindingThreshold = 0f;
		}
		else
		{
			FillHoles = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FillHoles_Offset), 0, FillHoles_PropertyAddress.Address);
			TrimFlaps = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, TrimFlaps_Offset), 0, TrimFlaps_PropertyAddress.Address);
			SimplifyOutput = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SimplifyOutput_Offset), 0, SimplifyOutput_PropertyAddress.Address);
			SimplifyPlanarTolerance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SimplifyPlanarTolerance_Offset));
			WindingThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WindingThreshold_Offset));
		}
	}

	static FGeometryScriptMeshSelfUnionOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMeshSelfUnionOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMeshSelfUnionOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMeshSelfUnionOptions");
		FGeometryScriptMeshSelfUnionOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FillHoles_PropertyAddress, intPtr, "bFillHoles");
		FillHoles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFillHoles");
		FillHoles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFillHoles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TrimFlaps_PropertyAddress, intPtr, "bTrimFlaps");
		TrimFlaps_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTrimFlaps");
		TrimFlaps_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTrimFlaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SimplifyOutput_PropertyAddress, intPtr, "bSimplifyOutput");
		SimplifyOutput_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSimplifyOutput");
		SimplifyOutput_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSimplifyOutput", Classes.FBoolProperty);
		SimplifyPlanarTolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimplifyPlanarTolerance");
		SimplifyPlanarTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimplifyPlanarTolerance", Classes.FFloatProperty);
		WindingThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindingThreshold");
		WindingThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindingThreshold", Classes.FFloatProperty);
		FGeometryScriptMeshSelfUnionOptions_IsValid = intPtr != IntPtr.Zero && FillHoles_IsValid && TrimFlaps_IsValid && SimplifyOutput_IsValid && SimplifyPlanarTolerance_IsValid && WindingThreshold_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMeshSelfUnionOptions", FGeometryScriptMeshSelfUnionOptions_IsValid);
	}
}
