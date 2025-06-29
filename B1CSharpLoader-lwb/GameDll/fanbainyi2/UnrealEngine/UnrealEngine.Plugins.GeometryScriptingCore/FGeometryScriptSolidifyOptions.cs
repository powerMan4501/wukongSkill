using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSolidifyOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptSolidifyOptions
{
	private static bool GridParameters_IsValid;

	private static int GridParameters_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSolidifyOptions:GridParameters")]
	public FGeometryScript3DGridParameters GridParameters;

	private static bool WindingThreshold_IsValid;

	private static int WindingThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSolidifyOptions:WindingThreshold")]
	public float WindingThreshold;

	private static bool SolidAtBoundaries_IsValid;

	private static FFieldAddress SolidAtBoundaries_PropertyAddress;

	private static int SolidAtBoundaries_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSolidifyOptions:bSolidAtBoundaries")]
	public bool SolidAtBoundaries;

	private static bool ExtendBounds_IsValid;

	private static int ExtendBounds_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSolidifyOptions:ExtendBounds")]
	public float ExtendBounds;

	private static bool SurfaceSearchSteps_IsValid;

	private static int SurfaceSearchSteps_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSolidifyOptions:SurfaceSearchSteps")]
	public int SurfaceSearchSteps;

	private static bool FGeometryScriptSolidifyOptions_IsValid;

	private static int FGeometryScriptSolidifyOptions_StructSize;

	public FGeometryScriptSolidifyOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptSolidifyOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptSolidifyOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptSolidifyOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptSolidifyOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptSolidifyOptions(nativeBuffer + arrayIndex * FGeometryScriptSolidifyOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptSolidifyOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptSolidifyOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSolidifyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSolidifyOptions");
			return;
		}
		FGeometryScript3DGridParameters.ToNative(IntPtr.Add(nativeStruct, GridParameters_Offset), GridParameters);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WindingThreshold_Offset), WindingThreshold);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SolidAtBoundaries_Offset), 0, SolidAtBoundaries_PropertyAddress.Address, SolidAtBoundaries);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ExtendBounds_Offset), ExtendBounds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SurfaceSearchSteps_Offset), SurfaceSearchSteps);
	}

	public FGeometryScriptSolidifyOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSolidifyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSolidifyOptions");
			GridParameters = default(FGeometryScript3DGridParameters);
			WindingThreshold = 0f;
			SolidAtBoundaries = false;
			ExtendBounds = 0f;
			SurfaceSearchSteps = 0;
		}
		else
		{
			GridParameters = FGeometryScript3DGridParameters.FromNative(IntPtr.Add(nativeStruct, GridParameters_Offset));
			WindingThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WindingThreshold_Offset));
			SolidAtBoundaries = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SolidAtBoundaries_Offset), 0, SolidAtBoundaries_PropertyAddress.Address);
			ExtendBounds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ExtendBounds_Offset));
			SurfaceSearchSteps = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SurfaceSearchSteps_Offset));
		}
	}

	static FGeometryScriptSolidifyOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptSolidifyOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptSolidifyOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptSolidifyOptions");
		FGeometryScriptSolidifyOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		GridParameters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GridParameters");
		GridParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GridParameters", Classes.FStructProperty);
		WindingThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindingThreshold");
		WindingThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindingThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SolidAtBoundaries_PropertyAddress, intPtr, "bSolidAtBoundaries");
		SolidAtBoundaries_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSolidAtBoundaries");
		SolidAtBoundaries_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSolidAtBoundaries", Classes.FBoolProperty);
		ExtendBounds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExtendBounds");
		ExtendBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExtendBounds", Classes.FFloatProperty);
		SurfaceSearchSteps_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SurfaceSearchSteps");
		SurfaceSearchSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SurfaceSearchSteps", Classes.FIntProperty);
		FGeometryScriptSolidifyOptions_IsValid = intPtr != IntPtr.Zero && GridParameters_IsValid && WindingThreshold_IsValid && SolidAtBoundaries_IsValid && ExtendBounds_IsValid && SurfaceSearchSteps_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptSolidifyOptions", FGeometryScriptSolidifyOptions_IsValid);
	}
}
