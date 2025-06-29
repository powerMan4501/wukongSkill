using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptCopyMeshToAssetOptions
{
	private static bool EnableRecomputeNormals_IsValid;

	private static FFieldAddress EnableRecomputeNormals_PropertyAddress;

	private static int EnableRecomputeNormals_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions:bEnableRecomputeNormals")]
	public bool EnableRecomputeNormals;

	private static bool EnableRecomputeTangents_IsValid;

	private static FFieldAddress EnableRecomputeTangents_PropertyAddress;

	private static int EnableRecomputeTangents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions:bEnableRecomputeTangents")]
	public bool EnableRecomputeTangents;

	private static bool EnableRemoveDegenerates_IsValid;

	private static FFieldAddress EnableRemoveDegenerates_PropertyAddress;

	private static int EnableRemoveDegenerates_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions:bEnableRemoveDegenerates")]
	public bool EnableRemoveDegenerates;

	private static bool ReplaceMaterials_IsValid;

	private static FFieldAddress ReplaceMaterials_PropertyAddress;

	private static int ReplaceMaterials_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions:bReplaceMaterials")]
	public bool ReplaceMaterials;

	private static bool NewMaterials_IsValid;

	private static FFieldAddress NewMaterials_PropertyAddress;

	private static int NewMaterials_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions:NewMaterials")]
	public List<UMaterialInterface> NewMaterials;

	private static bool NewMaterialSlotNames_IsValid;

	private static FFieldAddress NewMaterialSlotNames_PropertyAddress;

	private static int NewMaterialSlotNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions:NewMaterialSlotNames")]
	public List<FName> NewMaterialSlotNames;

	private static bool ApplyNaniteSettings_IsValid;

	private static FFieldAddress ApplyNaniteSettings_PropertyAddress;

	private static int ApplyNaniteSettings_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions:bApplyNaniteSettings")]
	public bool ApplyNaniteSettings;

	private static bool NaniteSettings_IsValid;

	private static int NaniteSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions:NaniteSettings")]
	public FGeometryScriptNaniteOptions NaniteSettings;

	private static bool EmitTransaction_IsValid;

	private static FFieldAddress EmitTransaction_PropertyAddress;

	private static int EmitTransaction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions:bEmitTransaction")]
	public bool EmitTransaction;

	private static bool DeferMeshPostEditChange_IsValid;

	private static FFieldAddress DeferMeshPostEditChange_PropertyAddress;

	private static int DeferMeshPostEditChange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions:bDeferMeshPostEditChange")]
	public bool DeferMeshPostEditChange;

	private static bool FGeometryScriptCopyMeshToAssetOptions_IsValid;

	private static int FGeometryScriptCopyMeshToAssetOptions_StructSize;

	public FGeometryScriptCopyMeshToAssetOptions Copy()
	{
		FGeometryScriptCopyMeshToAssetOptions result = this;
		if (NewMaterials != null)
		{
			result.NewMaterials = new List<UMaterialInterface>(NewMaterials);
		}
		if (NewMaterialSlotNames != null)
		{
			result.NewMaterialSlotNames = new List<FName>(NewMaterialSlotNames);
		}
		return result;
	}

	public static FGeometryScriptCopyMeshToAssetOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptCopyMeshToAssetOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptCopyMeshToAssetOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptCopyMeshToAssetOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptCopyMeshToAssetOptions(nativeBuffer + arrayIndex * FGeometryScriptCopyMeshToAssetOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptCopyMeshToAssetOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptCopyMeshToAssetOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCopyMeshToAssetOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableRecomputeNormals_Offset), 0, EnableRecomputeNormals_PropertyAddress.Address, EnableRecomputeNormals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableRecomputeTangents_Offset), 0, EnableRecomputeTangents_PropertyAddress.Address, EnableRecomputeTangents);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableRemoveDegenerates_Offset), 0, EnableRemoveDegenerates_PropertyAddress.Address, EnableRemoveDegenerates);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ReplaceMaterials_Offset), 0, ReplaceMaterials_PropertyAddress.Address, ReplaceMaterials);
		new TArrayCopyMarshaler<UMaterialInterface>(1, NewMaterials_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).ToNative(IntPtr.Add(nativeStruct, NewMaterials_Offset), NewMaterials);
		new TArrayCopyMarshaler<FName>(1, NewMaterialSlotNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, NewMaterialSlotNames_Offset), NewMaterialSlotNames);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyNaniteSettings_Offset), 0, ApplyNaniteSettings_PropertyAddress.Address, ApplyNaniteSettings);
		FGeometryScriptNaniteOptions.ToNative(IntPtr.Add(nativeStruct, NaniteSettings_Offset), NaniteSettings);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EmitTransaction_Offset), 0, EmitTransaction_PropertyAddress.Address, EmitTransaction);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DeferMeshPostEditChange_Offset), 0, DeferMeshPostEditChange_PropertyAddress.Address, DeferMeshPostEditChange);
	}

	public FGeometryScriptCopyMeshToAssetOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCopyMeshToAssetOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions");
			EnableRecomputeNormals = false;
			EnableRecomputeTangents = false;
			EnableRemoveDegenerates = false;
			ReplaceMaterials = false;
			NewMaterials = null;
			NewMaterialSlotNames = null;
			ApplyNaniteSettings = false;
			NaniteSettings = default(FGeometryScriptNaniteOptions);
			EmitTransaction = false;
			DeferMeshPostEditChange = false;
		}
		else
		{
			EnableRecomputeNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableRecomputeNormals_Offset), 0, EnableRecomputeNormals_PropertyAddress.Address);
			EnableRecomputeTangents = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableRecomputeTangents_Offset), 0, EnableRecomputeTangents_PropertyAddress.Address);
			EnableRemoveDegenerates = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableRemoveDegenerates_Offset), 0, EnableRemoveDegenerates_PropertyAddress.Address);
			ReplaceMaterials = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ReplaceMaterials_Offset), 0, ReplaceMaterials_PropertyAddress.Address);
			NewMaterials = new TArrayCopyMarshaler<UMaterialInterface>(1, NewMaterials_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).FromNative(IntPtr.Add(nativeStruct, NewMaterials_Offset));
			NewMaterialSlotNames = new TArrayCopyMarshaler<FName>(1, NewMaterialSlotNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, NewMaterialSlotNames_Offset));
			ApplyNaniteSettings = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyNaniteSettings_Offset), 0, ApplyNaniteSettings_PropertyAddress.Address);
			NaniteSettings = FGeometryScriptNaniteOptions.FromNative(IntPtr.Add(nativeStruct, NaniteSettings_Offset));
			EmitTransaction = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EmitTransaction_Offset), 0, EmitTransaction_PropertyAddress.Address);
			DeferMeshPostEditChange = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DeferMeshPostEditChange_Offset), 0, DeferMeshPostEditChange_PropertyAddress.Address);
		}
	}

	static FGeometryScriptCopyMeshToAssetOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptCopyMeshToAssetOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptCopyMeshToAssetOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions");
		FGeometryScriptCopyMeshToAssetOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EnableRecomputeNormals_PropertyAddress, intPtr, "bEnableRecomputeNormals");
		EnableRecomputeNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableRecomputeNormals");
		EnableRecomputeNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableRecomputeNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableRecomputeTangents_PropertyAddress, intPtr, "bEnableRecomputeTangents");
		EnableRecomputeTangents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableRecomputeTangents");
		EnableRecomputeTangents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableRecomputeTangents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableRemoveDegenerates_PropertyAddress, intPtr, "bEnableRemoveDegenerates");
		EnableRemoveDegenerates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableRemoveDegenerates");
		EnableRemoveDegenerates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableRemoveDegenerates", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMaterials_PropertyAddress, intPtr, "bReplaceMaterials");
		ReplaceMaterials_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReplaceMaterials");
		ReplaceMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReplaceMaterials", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NewMaterials_PropertyAddress, intPtr, "NewMaterials");
		NewMaterials_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewMaterials");
		NewMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewMaterials", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref NewMaterialSlotNames_PropertyAddress, intPtr, "NewMaterialSlotNames");
		NewMaterialSlotNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewMaterialSlotNames");
		NewMaterialSlotNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewMaterialSlotNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyNaniteSettings_PropertyAddress, intPtr, "bApplyNaniteSettings");
		ApplyNaniteSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyNaniteSettings");
		ApplyNaniteSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyNaniteSettings", Classes.FBoolProperty);
		NaniteSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NaniteSettings");
		NaniteSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NaniteSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EmitTransaction_PropertyAddress, intPtr, "bEmitTransaction");
		EmitTransaction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEmitTransaction");
		EmitTransaction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEmitTransaction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeferMeshPostEditChange_PropertyAddress, intPtr, "bDeferMeshPostEditChange");
		DeferMeshPostEditChange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDeferMeshPostEditChange");
		DeferMeshPostEditChange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDeferMeshPostEditChange", Classes.FBoolProperty);
		FGeometryScriptCopyMeshToAssetOptions_IsValid = intPtr != IntPtr.Zero && EnableRecomputeNormals_IsValid && EnableRecomputeTangents_IsValid && EnableRemoveDegenerates_IsValid && ReplaceMaterials_IsValid && NewMaterials_IsValid && NewMaterialSlotNames_IsValid && ApplyNaniteSettings_IsValid && NaniteSettings_IsValid && EmitTransaction_IsValid && DeferMeshPostEditChange_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptCopyMeshToAssetOptions", FGeometryScriptCopyMeshToAssetOptions_IsValid);
	}
}
