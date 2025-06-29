using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMeshBevelOptions
{
	private static bool BevelDistance_IsValid;

	private static int BevelDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions:BevelDistance")]
	public float BevelDistance;

	private static bool InferMaterialID_IsValid;

	private static FFieldAddress InferMaterialID_PropertyAddress;

	private static int InferMaterialID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions:bInferMaterialID")]
	public bool InferMaterialID;

	private static bool SetMaterialID_IsValid;

	private static int SetMaterialID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions:SetMaterialID")]
	public int SetMaterialID;

	private static bool ApplyFilterBox_IsValid;

	private static FFieldAddress ApplyFilterBox_PropertyAddress;

	private static int ApplyFilterBox_Offset;

	[UProperty(Flags = (PropFlags)6759867280785924uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions:bApplyFilterBox")]
	public bool ApplyFilterBox;

	private static bool FilterBox_IsValid;

	private static int FilterBox_Offset;

	[UProperty(Flags = (PropFlags)4508067467100676uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions:FilterBox")]
	public FBox FilterBox;

	private static bool FilterBoxTransform_IsValid;

	private static int FilterBoxTransform_Offset;

	[UProperty(Flags = (PropFlags)4508067467100164uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions:FilterBoxTransform")]
	public FTransform FilterBoxTransform;

	private static bool FullyContained_IsValid;

	private static FFieldAddress FullyContained_PropertyAddress;

	private static int FullyContained_Offset;

	[UProperty(Flags = (PropFlags)6759867280785924uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions:bFullyContained")]
	public bool FullyContained;

	private static bool FGeometryScriptMeshBevelOptions_IsValid;

	private static int FGeometryScriptMeshBevelOptions_StructSize;

	public FGeometryScriptMeshBevelOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptMeshBevelOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMeshBevelOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMeshBevelOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMeshBevelOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMeshBevelOptions(nativeBuffer + arrayIndex * FGeometryScriptMeshBevelOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMeshBevelOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMeshBevelOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshBevelOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BevelDistance_Offset), BevelDistance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InferMaterialID_Offset), 0, InferMaterialID_PropertyAddress.Address, InferMaterialID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SetMaterialID_Offset), SetMaterialID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyFilterBox_Offset), 0, ApplyFilterBox_PropertyAddress.Address, ApplyFilterBox);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(nativeStruct, FilterBox_Offset), FilterBox);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, FilterBoxTransform_Offset), FilterBoxTransform);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FullyContained_Offset), 0, FullyContained_PropertyAddress.Address, FullyContained);
	}

	public FGeometryScriptMeshBevelOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshBevelOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions");
			BevelDistance = 0f;
			InferMaterialID = false;
			SetMaterialID = 0;
			ApplyFilterBox = false;
			FilterBox = default(FBox);
			FilterBoxTransform = default(FTransform);
			FullyContained = false;
		}
		else
		{
			BevelDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BevelDistance_Offset));
			InferMaterialID = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InferMaterialID_Offset), 0, InferMaterialID_PropertyAddress.Address);
			SetMaterialID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SetMaterialID_Offset));
			ApplyFilterBox = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyFilterBox_Offset), 0, ApplyFilterBox_PropertyAddress.Address);
			FilterBox = BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(nativeStruct, FilterBox_Offset));
			FilterBoxTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, FilterBoxTransform_Offset));
			FullyContained = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FullyContained_Offset), 0, FullyContained_PropertyAddress.Address);
		}
	}

	static FGeometryScriptMeshBevelOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMeshBevelOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMeshBevelOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions");
		FGeometryScriptMeshBevelOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		BevelDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BevelDistance");
		BevelDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BevelDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InferMaterialID_PropertyAddress, intPtr, "bInferMaterialID");
		InferMaterialID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInferMaterialID");
		InferMaterialID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInferMaterialID", Classes.FBoolProperty);
		SetMaterialID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SetMaterialID");
		SetMaterialID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SetMaterialID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyFilterBox_PropertyAddress, intPtr, "bApplyFilterBox");
		ApplyFilterBox_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyFilterBox");
		ApplyFilterBox_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyFilterBox", Classes.FBoolProperty);
		FilterBox_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterBox");
		FilterBox_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterBox", Classes.FStructProperty);
		FilterBoxTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterBoxTransform");
		FilterBoxTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterBoxTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FullyContained_PropertyAddress, intPtr, "bFullyContained");
		FullyContained_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFullyContained");
		FullyContained_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFullyContained", Classes.FBoolProperty);
		FGeometryScriptMeshBevelOptions_IsValid = intPtr != IntPtr.Zero && BevelDistance_IsValid && InferMaterialID_IsValid && SetMaterialID_IsValid && ApplyFilterBox_IsValid && FilterBox_IsValid && FilterBoxTransform_IsValid && FullyContained_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMeshBevelOptions", FGeometryScriptMeshBevelOptions_IsValid);
	}
}
