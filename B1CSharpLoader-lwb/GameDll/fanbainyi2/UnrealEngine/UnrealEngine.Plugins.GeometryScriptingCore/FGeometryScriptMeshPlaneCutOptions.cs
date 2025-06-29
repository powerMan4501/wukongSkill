using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneCutOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMeshPlaneCutOptions
{
	private static bool FillHoles_IsValid;

	private static FFieldAddress FillHoles_PropertyAddress;

	private static int FillHoles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneCutOptions:bFillHoles")]
	public bool FillHoles;

	private static bool FillSpans_IsValid;

	private static FFieldAddress FillSpans_PropertyAddress;

	private static int FillSpans_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneCutOptions:bFillSpans")]
	public bool FillSpans;

	private static bool FlipCutSide_IsValid;

	private static FFieldAddress FlipCutSide_PropertyAddress;

	private static int FlipCutSide_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneCutOptions:bFlipCutSide")]
	public bool FlipCutSide;

	private static bool UVWorldDimension_IsValid;

	private static int UVWorldDimension_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneCutOptions:UVWorldDimension")]
	public float UVWorldDimension;

	private static bool FGeometryScriptMeshPlaneCutOptions_IsValid;

	private static int FGeometryScriptMeshPlaneCutOptions_StructSize;

	public FGeometryScriptMeshPlaneCutOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptMeshPlaneCutOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMeshPlaneCutOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMeshPlaneCutOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMeshPlaneCutOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMeshPlaneCutOptions(nativeBuffer + arrayIndex * FGeometryScriptMeshPlaneCutOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMeshPlaneCutOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMeshPlaneCutOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshPlaneCutOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneCutOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FillHoles_Offset), 0, FillHoles_PropertyAddress.Address, FillHoles);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FillSpans_Offset), 0, FillSpans_PropertyAddress.Address, FillSpans);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FlipCutSide_Offset), 0, FlipCutSide_PropertyAddress.Address, FlipCutSide);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, UVWorldDimension_Offset), UVWorldDimension);
	}

	public FGeometryScriptMeshPlaneCutOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshPlaneCutOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneCutOptions");
			FillHoles = false;
			FillSpans = false;
			FlipCutSide = false;
			UVWorldDimension = 0f;
		}
		else
		{
			FillHoles = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FillHoles_Offset), 0, FillHoles_PropertyAddress.Address);
			FillSpans = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FillSpans_Offset), 0, FillSpans_PropertyAddress.Address);
			FlipCutSide = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FlipCutSide_Offset), 0, FlipCutSide_PropertyAddress.Address);
			UVWorldDimension = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, UVWorldDimension_Offset));
		}
	}

	static FGeometryScriptMeshPlaneCutOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMeshPlaneCutOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMeshPlaneCutOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneCutOptions");
		FGeometryScriptMeshPlaneCutOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FillHoles_PropertyAddress, intPtr, "bFillHoles");
		FillHoles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFillHoles");
		FillHoles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFillHoles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FillSpans_PropertyAddress, intPtr, "bFillSpans");
		FillSpans_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFillSpans");
		FillSpans_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFillSpans", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FlipCutSide_PropertyAddress, intPtr, "bFlipCutSide");
		FlipCutSide_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFlipCutSide");
		FlipCutSide_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFlipCutSide", Classes.FBoolProperty);
		UVWorldDimension_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVWorldDimension");
		UVWorldDimension_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVWorldDimension", Classes.FFloatProperty);
		FGeometryScriptMeshPlaneCutOptions_IsValid = intPtr != IntPtr.Zero && FillHoles_IsValid && FillSpans_IsValid && FlipCutSide_IsValid && UVWorldDimension_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMeshPlaneCutOptions", FGeometryScriptMeshPlaneCutOptions_IsValid);
	}
}
