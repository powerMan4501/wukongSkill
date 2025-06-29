using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshOffsetOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMeshOffsetOptions
{
	private static bool OffsetDistance_IsValid;

	private static int OffsetDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshOffsetOptions:OffsetDistance")]
	public float OffsetDistance;

	private static bool FixedBoundary_IsValid;

	private static FFieldAddress FixedBoundary_PropertyAddress;

	private static int FixedBoundary_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshOffsetOptions:bFixedBoundary")]
	public bool FixedBoundary;

	private static bool SolveSteps_IsValid;

	private static int SolveSteps_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshOffsetOptions:SolveSteps")]
	public int SolveSteps;

	private static bool SmoothAlpha_IsValid;

	private static int SmoothAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshOffsetOptions:SmoothAlpha")]
	public float SmoothAlpha;

	private static bool ReprojectDuringSmoothing_IsValid;

	private static FFieldAddress ReprojectDuringSmoothing_PropertyAddress;

	private static int ReprojectDuringSmoothing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshOffsetOptions:bReprojectDuringSmoothing")]
	public bool ReprojectDuringSmoothing;

	private static bool BoundaryAlpha_IsValid;

	private static int BoundaryAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshOffsetOptions:BoundaryAlpha")]
	public float BoundaryAlpha;

	private static bool FGeometryScriptMeshOffsetOptions_IsValid;

	private static int FGeometryScriptMeshOffsetOptions_StructSize;

	public FGeometryScriptMeshOffsetOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptMeshOffsetOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMeshOffsetOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMeshOffsetOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMeshOffsetOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMeshOffsetOptions(nativeBuffer + arrayIndex * FGeometryScriptMeshOffsetOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMeshOffsetOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMeshOffsetOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshOffsetOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshOffsetOptions");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OffsetDistance_Offset), OffsetDistance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FixedBoundary_Offset), 0, FixedBoundary_PropertyAddress.Address, FixedBoundary);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SolveSteps_Offset), SolveSteps);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SmoothAlpha_Offset), SmoothAlpha);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ReprojectDuringSmoothing_Offset), 0, ReprojectDuringSmoothing_PropertyAddress.Address, ReprojectDuringSmoothing);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BoundaryAlpha_Offset), BoundaryAlpha);
	}

	public FGeometryScriptMeshOffsetOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshOffsetOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshOffsetOptions");
			OffsetDistance = 0f;
			FixedBoundary = false;
			SolveSteps = 0;
			SmoothAlpha = 0f;
			ReprojectDuringSmoothing = false;
			BoundaryAlpha = 0f;
		}
		else
		{
			OffsetDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OffsetDistance_Offset));
			FixedBoundary = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FixedBoundary_Offset), 0, FixedBoundary_PropertyAddress.Address);
			SolveSteps = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SolveSteps_Offset));
			SmoothAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SmoothAlpha_Offset));
			ReprojectDuringSmoothing = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ReprojectDuringSmoothing_Offset), 0, ReprojectDuringSmoothing_PropertyAddress.Address);
			BoundaryAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BoundaryAlpha_Offset));
		}
	}

	static FGeometryScriptMeshOffsetOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMeshOffsetOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMeshOffsetOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMeshOffsetOptions");
		FGeometryScriptMeshOffsetOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		OffsetDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OffsetDistance");
		OffsetDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OffsetDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FixedBoundary_PropertyAddress, intPtr, "bFixedBoundary");
		FixedBoundary_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFixedBoundary");
		FixedBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFixedBoundary", Classes.FBoolProperty);
		SolveSteps_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SolveSteps");
		SolveSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SolveSteps", Classes.FIntProperty);
		SmoothAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SmoothAlpha");
		SmoothAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SmoothAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReprojectDuringSmoothing_PropertyAddress, intPtr, "bReprojectDuringSmoothing");
		ReprojectDuringSmoothing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReprojectDuringSmoothing");
		ReprojectDuringSmoothing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReprojectDuringSmoothing", Classes.FBoolProperty);
		BoundaryAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoundaryAlpha");
		BoundaryAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoundaryAlpha", Classes.FFloatProperty);
		FGeometryScriptMeshOffsetOptions_IsValid = intPtr != IntPtr.Zero && OffsetDistance_IsValid && FixedBoundary_IsValid && SolveSteps_IsValid && SmoothAlpha_IsValid && ReprojectDuringSmoothing_IsValid && BoundaryAlpha_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMeshOffsetOptions", FGeometryScriptMeshOffsetOptions_IsValid);
	}
}
