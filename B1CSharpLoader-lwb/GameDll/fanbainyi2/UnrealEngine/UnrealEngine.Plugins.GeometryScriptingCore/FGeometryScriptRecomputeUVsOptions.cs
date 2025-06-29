using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRecomputeUVsOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptRecomputeUVsOptions
{
	private static bool Method_IsValid;

	private static FFieldAddress Method_PropertyAddress;

	private static int Method_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRecomputeUVsOptions:Method")]
	public EGeometryScriptUVFlattenMethod Method;

	private static bool IslandSource_IsValid;

	private static FFieldAddress IslandSource_PropertyAddress;

	private static int IslandSource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRecomputeUVsOptions:IslandSource")]
	public EGeometryScriptUVIslandSource IslandSource;

	private static bool ExpMapOptions_IsValid;

	private static int ExpMapOptions_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRecomputeUVsOptions:ExpMapOptions")]
	public FGeometryScriptExpMapUVOptions ExpMapOptions;

	private static bool GroupLayer_IsValid;

	private static int GroupLayer_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRecomputeUVsOptions:GroupLayer")]
	public FGeometryScriptGroupLayer GroupLayer;

	private static bool AutoAlignIslandsWithAxes_IsValid;

	private static FFieldAddress AutoAlignIslandsWithAxes_PropertyAddress;

	private static int AutoAlignIslandsWithAxes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRecomputeUVsOptions:bAutoAlignIslandsWithAxes")]
	public bool AutoAlignIslandsWithAxes;

	private static bool FGeometryScriptRecomputeUVsOptions_IsValid;

	private static int FGeometryScriptRecomputeUVsOptions_StructSize;

	public FGeometryScriptRecomputeUVsOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptRecomputeUVsOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptRecomputeUVsOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptRecomputeUVsOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptRecomputeUVsOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptRecomputeUVsOptions(nativeBuffer + arrayIndex * FGeometryScriptRecomputeUVsOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptRecomputeUVsOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptRecomputeUVsOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRecomputeUVsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRecomputeUVsOptions");
			return;
		}
		EnumMarshaler<EGeometryScriptUVFlattenMethod>.ToNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address, Method);
		EnumMarshaler<EGeometryScriptUVIslandSource>.ToNative(IntPtr.Add(nativeStruct, IslandSource_Offset), 0, IslandSource_PropertyAddress.Address, IslandSource);
		FGeometryScriptExpMapUVOptions.ToNative(IntPtr.Add(nativeStruct, ExpMapOptions_Offset), ExpMapOptions);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(nativeStruct, GroupLayer_Offset), GroupLayer);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoAlignIslandsWithAxes_Offset), 0, AutoAlignIslandsWithAxes_PropertyAddress.Address, AutoAlignIslandsWithAxes);
	}

	public FGeometryScriptRecomputeUVsOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRecomputeUVsOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRecomputeUVsOptions");
			Method = EGeometryScriptUVFlattenMethod.ExpMap;
			IslandSource = EGeometryScriptUVIslandSource.PolyGroups;
			ExpMapOptions = default(FGeometryScriptExpMapUVOptions);
			GroupLayer = default(FGeometryScriptGroupLayer);
			AutoAlignIslandsWithAxes = false;
		}
		else
		{
			Method = EnumMarshaler<EGeometryScriptUVFlattenMethod>.FromNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address);
			IslandSource = EnumMarshaler<EGeometryScriptUVIslandSource>.FromNative(IntPtr.Add(nativeStruct, IslandSource_Offset), 0, IslandSource_PropertyAddress.Address);
			ExpMapOptions = FGeometryScriptExpMapUVOptions.FromNative(IntPtr.Add(nativeStruct, ExpMapOptions_Offset));
			GroupLayer = FGeometryScriptGroupLayer.FromNative(IntPtr.Add(nativeStruct, GroupLayer_Offset));
			AutoAlignIslandsWithAxes = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoAlignIslandsWithAxes_Offset), 0, AutoAlignIslandsWithAxes_PropertyAddress.Address);
		}
	}

	static FGeometryScriptRecomputeUVsOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptRecomputeUVsOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptRecomputeUVsOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptRecomputeUVsOptions");
		FGeometryScriptRecomputeUVsOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Method_PropertyAddress, intPtr, "Method");
		Method_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Method");
		Method_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Method", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IslandSource_PropertyAddress, intPtr, "IslandSource");
		IslandSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IslandSource");
		IslandSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IslandSource", Classes.FEnumProperty);
		ExpMapOptions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExpMapOptions");
		ExpMapOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExpMapOptions", Classes.FStructProperty);
		GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupLayer");
		GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAlignIslandsWithAxes_PropertyAddress, intPtr, "bAutoAlignIslandsWithAxes");
		AutoAlignIslandsWithAxes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoAlignIslandsWithAxes");
		AutoAlignIslandsWithAxes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoAlignIslandsWithAxes", Classes.FBoolProperty);
		FGeometryScriptRecomputeUVsOptions_IsValid = intPtr != IntPtr.Zero && Method_IsValid && IslandSource_IsValid && ExpMapOptions_IsValid && GroupLayer_IsValid && AutoAlignIslandsWithAxes_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptRecomputeUVsOptions", FGeometryScriptRecomputeUVsOptions_IsValid);
	}
}
