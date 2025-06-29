using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSpatialQueryOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptSpatialQueryOptions
{
	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSpatialQueryOptions:MaxDistance")]
	public float MaxDistance;

	private static bool AllowUnsafeModifiedQueries_IsValid;

	private static FFieldAddress AllowUnsafeModifiedQueries_PropertyAddress;

	private static int AllowUnsafeModifiedQueries_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSpatialQueryOptions:bAllowUnsafeModifiedQueries")]
	public bool AllowUnsafeModifiedQueries;

	private static bool WindingIsoThreshold_IsValid;

	private static int WindingIsoThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSpatialQueryOptions:WindingIsoThreshold")]
	public float WindingIsoThreshold;

	private static bool FGeometryScriptSpatialQueryOptions_IsValid;

	private static int FGeometryScriptSpatialQueryOptions_StructSize;

	public FGeometryScriptSpatialQueryOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptSpatialQueryOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptSpatialQueryOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptSpatialQueryOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptSpatialQueryOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptSpatialQueryOptions(nativeBuffer + arrayIndex * FGeometryScriptSpatialQueryOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptSpatialQueryOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptSpatialQueryOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSpatialQueryOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSpatialQueryOptions");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDistance_Offset), MaxDistance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowUnsafeModifiedQueries_Offset), 0, AllowUnsafeModifiedQueries_PropertyAddress.Address, AllowUnsafeModifiedQueries);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WindingIsoThreshold_Offset), WindingIsoThreshold);
	}

	public FGeometryScriptSpatialQueryOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSpatialQueryOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSpatialQueryOptions");
			MaxDistance = 0f;
			AllowUnsafeModifiedQueries = false;
			WindingIsoThreshold = 0f;
		}
		else
		{
			MaxDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDistance_Offset));
			AllowUnsafeModifiedQueries = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowUnsafeModifiedQueries_Offset), 0, AllowUnsafeModifiedQueries_PropertyAddress.Address);
			WindingIsoThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WindingIsoThreshold_Offset));
		}
	}

	static FGeometryScriptSpatialQueryOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptSpatialQueryOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptSpatialQueryOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptSpatialQueryOptions");
		FGeometryScriptSpatialQueryOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		MaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDistance");
		MaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowUnsafeModifiedQueries_PropertyAddress, intPtr, "bAllowUnsafeModifiedQueries");
		AllowUnsafeModifiedQueries_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowUnsafeModifiedQueries");
		AllowUnsafeModifiedQueries_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowUnsafeModifiedQueries", Classes.FBoolProperty);
		WindingIsoThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindingIsoThreshold");
		WindingIsoThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindingIsoThreshold", Classes.FFloatProperty);
		FGeometryScriptSpatialQueryOptions_IsValid = intPtr != IntPtr.Zero && MaxDistance_IsValid && AllowUnsafeModifiedQueries_IsValid && WindingIsoThreshold_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptSpatialQueryOptions", FGeometryScriptSpatialQueryOptions_IsValid);
	}
}
