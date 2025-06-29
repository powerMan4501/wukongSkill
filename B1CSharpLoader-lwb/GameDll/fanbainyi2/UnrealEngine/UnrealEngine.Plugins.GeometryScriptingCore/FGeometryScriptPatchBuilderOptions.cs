using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptPatchBuilderOptions
{
	private static bool InitialPatchCount_IsValid;

	private static int InitialPatchCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions:InitialPatchCount")]
	public int InitialPatchCount;

	private static bool MinPatchSize_IsValid;

	private static int MinPatchSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions:MinPatchSize")]
	public int MinPatchSize;

	private static bool PatchCurvatureAlignmentWeight_IsValid;

	private static int PatchCurvatureAlignmentWeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions:PatchCurvatureAlignmentWeight")]
	public float PatchCurvatureAlignmentWeight;

	private static bool PatchMergingMetricThresh_IsValid;

	private static int PatchMergingMetricThresh_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions:PatchMergingMetricThresh")]
	public float PatchMergingMetricThresh;

	private static bool PatchMergingAngleThresh_IsValid;

	private static int PatchMergingAngleThresh_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions:PatchMergingAngleThresh")]
	public float PatchMergingAngleThresh;

	private static bool ExpMapOptions_IsValid;

	private static int ExpMapOptions_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions:ExpMapOptions")]
	public FGeometryScriptExpMapUVOptions ExpMapOptions;

	private static bool RespectInputGroups_IsValid;

	private static FFieldAddress RespectInputGroups_PropertyAddress;

	private static int RespectInputGroups_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions:bRespectInputGroups")]
	public bool RespectInputGroups;

	private static bool GroupLayer_IsValid;

	private static int GroupLayer_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions:GroupLayer")]
	public FGeometryScriptGroupLayer GroupLayer;

	private static bool AutoPack_IsValid;

	private static FFieldAddress AutoPack_PropertyAddress;

	private static int AutoPack_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions:bAutoPack")]
	public bool AutoPack;

	private static bool PackingOptions_IsValid;

	private static int PackingOptions_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions:PackingOptions")]
	public FGeometryScriptRepackUVsOptions PackingOptions;

	private static bool FGeometryScriptPatchBuilderOptions_IsValid;

	private static int FGeometryScriptPatchBuilderOptions_StructSize;

	public FGeometryScriptPatchBuilderOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptPatchBuilderOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptPatchBuilderOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptPatchBuilderOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptPatchBuilderOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptPatchBuilderOptions(nativeBuffer + arrayIndex * FGeometryScriptPatchBuilderOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptPatchBuilderOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptPatchBuilderOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPatchBuilderOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InitialPatchCount_Offset), InitialPatchCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MinPatchSize_Offset), MinPatchSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PatchCurvatureAlignmentWeight_Offset), PatchCurvatureAlignmentWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PatchMergingMetricThresh_Offset), PatchMergingMetricThresh);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PatchMergingAngleThresh_Offset), PatchMergingAngleThresh);
		FGeometryScriptExpMapUVOptions.ToNative(IntPtr.Add(nativeStruct, ExpMapOptions_Offset), ExpMapOptions);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RespectInputGroups_Offset), 0, RespectInputGroups_PropertyAddress.Address, RespectInputGroups);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(nativeStruct, GroupLayer_Offset), GroupLayer);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoPack_Offset), 0, AutoPack_PropertyAddress.Address, AutoPack);
		FGeometryScriptRepackUVsOptions.ToNative(IntPtr.Add(nativeStruct, PackingOptions_Offset), PackingOptions);
	}

	public FGeometryScriptPatchBuilderOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptPatchBuilderOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions");
			InitialPatchCount = 0;
			MinPatchSize = 0;
			PatchCurvatureAlignmentWeight = 0f;
			PatchMergingMetricThresh = 0f;
			PatchMergingAngleThresh = 0f;
			ExpMapOptions = default(FGeometryScriptExpMapUVOptions);
			RespectInputGroups = false;
			GroupLayer = default(FGeometryScriptGroupLayer);
			AutoPack = false;
			PackingOptions = default(FGeometryScriptRepackUVsOptions);
		}
		else
		{
			InitialPatchCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InitialPatchCount_Offset));
			MinPatchSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MinPatchSize_Offset));
			PatchCurvatureAlignmentWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PatchCurvatureAlignmentWeight_Offset));
			PatchMergingMetricThresh = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PatchMergingMetricThresh_Offset));
			PatchMergingAngleThresh = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PatchMergingAngleThresh_Offset));
			ExpMapOptions = FGeometryScriptExpMapUVOptions.FromNative(IntPtr.Add(nativeStruct, ExpMapOptions_Offset));
			RespectInputGroups = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RespectInputGroups_Offset), 0, RespectInputGroups_PropertyAddress.Address);
			GroupLayer = FGeometryScriptGroupLayer.FromNative(IntPtr.Add(nativeStruct, GroupLayer_Offset));
			AutoPack = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoPack_Offset), 0, AutoPack_PropertyAddress.Address);
			PackingOptions = FGeometryScriptRepackUVsOptions.FromNative(IntPtr.Add(nativeStruct, PackingOptions_Offset));
		}
	}

	static FGeometryScriptPatchBuilderOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptPatchBuilderOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptPatchBuilderOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions");
		FGeometryScriptPatchBuilderOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		InitialPatchCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialPatchCount");
		InitialPatchCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialPatchCount", Classes.FIntProperty);
		MinPatchSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinPatchSize");
		MinPatchSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinPatchSize", Classes.FIntProperty);
		PatchCurvatureAlignmentWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PatchCurvatureAlignmentWeight");
		PatchCurvatureAlignmentWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PatchCurvatureAlignmentWeight", Classes.FFloatProperty);
		PatchMergingMetricThresh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PatchMergingMetricThresh");
		PatchMergingMetricThresh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PatchMergingMetricThresh", Classes.FFloatProperty);
		PatchMergingAngleThresh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PatchMergingAngleThresh");
		PatchMergingAngleThresh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PatchMergingAngleThresh", Classes.FFloatProperty);
		ExpMapOptions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExpMapOptions");
		ExpMapOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExpMapOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RespectInputGroups_PropertyAddress, intPtr, "bRespectInputGroups");
		RespectInputGroups_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRespectInputGroups");
		RespectInputGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRespectInputGroups", Classes.FBoolProperty);
		GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupLayer");
		GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoPack_PropertyAddress, intPtr, "bAutoPack");
		AutoPack_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoPack");
		AutoPack_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoPack", Classes.FBoolProperty);
		PackingOptions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PackingOptions");
		PackingOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PackingOptions", Classes.FStructProperty);
		FGeometryScriptPatchBuilderOptions_IsValid = intPtr != IntPtr.Zero && InitialPatchCount_IsValid && MinPatchSize_IsValid && PatchCurvatureAlignmentWeight_IsValid && PatchMergingMetricThresh_IsValid && PatchMergingAngleThresh_IsValid && ExpMapOptions_IsValid && RespectInputGroups_IsValid && GroupLayer_IsValid && AutoPack_IsValid && PackingOptions_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptPatchBuilderOptions", FGeometryScriptPatchBuilderOptions_IsValid);
	}
}
