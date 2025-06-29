using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshMirrorOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMeshMirrorOptions
{
	private static bool ApplyPlaneCut_IsValid;

	private static FFieldAddress ApplyPlaneCut_PropertyAddress;

	private static int ApplyPlaneCut_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshMirrorOptions:bApplyPlaneCut")]
	public bool ApplyPlaneCut;

	private static bool FlipCutSide_IsValid;

	private static FFieldAddress FlipCutSide_PropertyAddress;

	private static int FlipCutSide_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshMirrorOptions:bFlipCutSide")]
	public bool FlipCutSide;

	private static bool WeldAlongPlane_IsValid;

	private static FFieldAddress WeldAlongPlane_PropertyAddress;

	private static int WeldAlongPlane_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshMirrorOptions:bWeldAlongPlane")]
	public bool WeldAlongPlane;

	private static bool FGeometryScriptMeshMirrorOptions_IsValid;

	private static int FGeometryScriptMeshMirrorOptions_StructSize;

	public FGeometryScriptMeshMirrorOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptMeshMirrorOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMeshMirrorOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMeshMirrorOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMeshMirrorOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMeshMirrorOptions(nativeBuffer + arrayIndex * FGeometryScriptMeshMirrorOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMeshMirrorOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMeshMirrorOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshMirrorOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshMirrorOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyPlaneCut_Offset), 0, ApplyPlaneCut_PropertyAddress.Address, ApplyPlaneCut);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FlipCutSide_Offset), 0, FlipCutSide_PropertyAddress.Address, FlipCutSide);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, WeldAlongPlane_Offset), 0, WeldAlongPlane_PropertyAddress.Address, WeldAlongPlane);
	}

	public FGeometryScriptMeshMirrorOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshMirrorOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshMirrorOptions");
			ApplyPlaneCut = false;
			FlipCutSide = false;
			WeldAlongPlane = false;
		}
		else
		{
			ApplyPlaneCut = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyPlaneCut_Offset), 0, ApplyPlaneCut_PropertyAddress.Address);
			FlipCutSide = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FlipCutSide_Offset), 0, FlipCutSide_PropertyAddress.Address);
			WeldAlongPlane = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, WeldAlongPlane_Offset), 0, WeldAlongPlane_PropertyAddress.Address);
		}
	}

	static FGeometryScriptMeshMirrorOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMeshMirrorOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMeshMirrorOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMeshMirrorOptions");
		FGeometryScriptMeshMirrorOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ApplyPlaneCut_PropertyAddress, intPtr, "bApplyPlaneCut");
		ApplyPlaneCut_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyPlaneCut");
		ApplyPlaneCut_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyPlaneCut", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FlipCutSide_PropertyAddress, intPtr, "bFlipCutSide");
		FlipCutSide_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFlipCutSide");
		FlipCutSide_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFlipCutSide", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WeldAlongPlane_PropertyAddress, intPtr, "bWeldAlongPlane");
		WeldAlongPlane_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWeldAlongPlane");
		WeldAlongPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWeldAlongPlane", Classes.FBoolProperty);
		FGeometryScriptMeshMirrorOptions_IsValid = intPtr != IntPtr.Zero && ApplyPlaneCut_IsValid && FlipCutSide_IsValid && WeldAlongPlane_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMeshMirrorOptions", FGeometryScriptMeshMirrorOptions_IsValid);
	}
}
