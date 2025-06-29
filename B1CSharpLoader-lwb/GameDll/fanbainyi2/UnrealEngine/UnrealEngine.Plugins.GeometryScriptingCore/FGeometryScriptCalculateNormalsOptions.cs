using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCalculateNormalsOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptCalculateNormalsOptions
{
	private static bool AngleWeighted_IsValid;

	private static FFieldAddress AngleWeighted_PropertyAddress;

	private static int AngleWeighted_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCalculateNormalsOptions:bAngleWeighted")]
	public bool AngleWeighted;

	private static bool AreaWeighted_IsValid;

	private static FFieldAddress AreaWeighted_PropertyAddress;

	private static int AreaWeighted_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCalculateNormalsOptions:bAreaWeighted")]
	public bool AreaWeighted;

	private static bool FGeometryScriptCalculateNormalsOptions_IsValid;

	private static int FGeometryScriptCalculateNormalsOptions_StructSize;

	public FGeometryScriptCalculateNormalsOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptCalculateNormalsOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptCalculateNormalsOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptCalculateNormalsOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptCalculateNormalsOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptCalculateNormalsOptions(nativeBuffer + arrayIndex * FGeometryScriptCalculateNormalsOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptCalculateNormalsOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptCalculateNormalsOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCalculateNormalsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptCalculateNormalsOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AngleWeighted_Offset), 0, AngleWeighted_PropertyAddress.Address, AngleWeighted);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AreaWeighted_Offset), 0, AreaWeighted_PropertyAddress.Address, AreaWeighted);
	}

	public FGeometryScriptCalculateNormalsOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCalculateNormalsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptCalculateNormalsOptions");
			AngleWeighted = false;
			AreaWeighted = false;
		}
		else
		{
			AngleWeighted = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AngleWeighted_Offset), 0, AngleWeighted_PropertyAddress.Address);
			AreaWeighted = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AreaWeighted_Offset), 0, AreaWeighted_PropertyAddress.Address);
		}
	}

	static FGeometryScriptCalculateNormalsOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptCalculateNormalsOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptCalculateNormalsOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptCalculateNormalsOptions");
		FGeometryScriptCalculateNormalsOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref AngleWeighted_PropertyAddress, intPtr, "bAngleWeighted");
		AngleWeighted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAngleWeighted");
		AngleWeighted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAngleWeighted", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AreaWeighted_PropertyAddress, intPtr, "bAreaWeighted");
		AreaWeighted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAreaWeighted");
		AreaWeighted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAreaWeighted", Classes.FBoolProperty);
		FGeometryScriptCalculateNormalsOptions_IsValid = intPtr != IntPtr.Zero && AngleWeighted_IsValid && AreaWeighted_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptCalculateNormalsOptions", FGeometryScriptCalculateNormalsOptions_IsValid);
	}
}
