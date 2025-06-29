using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRepackUVsOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptRepackUVsOptions
{
	private static bool TargetImageWidth_IsValid;

	private static int TargetImageWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRepackUVsOptions:TargetImageWidth")]
	public int TargetImageWidth;

	private static bool OptimizeIslandRotation_IsValid;

	private static FFieldAddress OptimizeIslandRotation_PropertyAddress;

	private static int OptimizeIslandRotation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRepackUVsOptions:bOptimizeIslandRotation")]
	public bool OptimizeIslandRotation;

	private static bool FGeometryScriptRepackUVsOptions_IsValid;

	private static int FGeometryScriptRepackUVsOptions_StructSize;

	public FGeometryScriptRepackUVsOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptRepackUVsOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptRepackUVsOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptRepackUVsOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptRepackUVsOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptRepackUVsOptions(nativeBuffer + arrayIndex * FGeometryScriptRepackUVsOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptRepackUVsOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptRepackUVsOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRepackUVsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRepackUVsOptions");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetImageWidth_Offset), TargetImageWidth);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OptimizeIslandRotation_Offset), 0, OptimizeIslandRotation_PropertyAddress.Address, OptimizeIslandRotation);
	}

	public FGeometryScriptRepackUVsOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRepackUVsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRepackUVsOptions");
			TargetImageWidth = 0;
			OptimizeIslandRotation = false;
		}
		else
		{
			TargetImageWidth = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetImageWidth_Offset));
			OptimizeIslandRotation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OptimizeIslandRotation_Offset), 0, OptimizeIslandRotation_PropertyAddress.Address);
		}
	}

	static FGeometryScriptRepackUVsOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptRepackUVsOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptRepackUVsOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptRepackUVsOptions");
		FGeometryScriptRepackUVsOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		TargetImageWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetImageWidth");
		TargetImageWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetImageWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OptimizeIslandRotation_PropertyAddress, intPtr, "bOptimizeIslandRotation");
		OptimizeIslandRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOptimizeIslandRotation");
		OptimizeIslandRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOptimizeIslandRotation", Classes.FBoolProperty);
		FGeometryScriptRepackUVsOptions_IsValid = intPtr != IntPtr.Zero && TargetImageWidth_IsValid && OptimizeIslandRotation_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptRepackUVsOptions", FGeometryScriptRepackUVsOptions_IsValid);
	}
}
