using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromAssetOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptCopyMeshFromAssetOptions
{
	private static bool ApplyBuildSettings_IsValid;

	private static FFieldAddress ApplyBuildSettings_PropertyAddress;

	private static int ApplyBuildSettings_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromAssetOptions:bApplyBuildSettings")]
	public bool ApplyBuildSettings;

	private static bool RequestTangents_IsValid;

	private static FFieldAddress RequestTangents_PropertyAddress;

	private static int RequestTangents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromAssetOptions:bRequestTangents")]
	public bool RequestTangents;

	private static bool IgnoreRemoveDegenerates_IsValid;

	private static FFieldAddress IgnoreRemoveDegenerates_PropertyAddress;

	private static int IgnoreRemoveDegenerates_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromAssetOptions:bIgnoreRemoveDegenerates")]
	public bool IgnoreRemoveDegenerates;

	private static bool FGeometryScriptCopyMeshFromAssetOptions_IsValid;

	private static int FGeometryScriptCopyMeshFromAssetOptions_StructSize;

	public FGeometryScriptCopyMeshFromAssetOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptCopyMeshFromAssetOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptCopyMeshFromAssetOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptCopyMeshFromAssetOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptCopyMeshFromAssetOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptCopyMeshFromAssetOptions(nativeBuffer + arrayIndex * FGeometryScriptCopyMeshFromAssetOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptCopyMeshFromAssetOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptCopyMeshFromAssetOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCopyMeshFromAssetOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromAssetOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyBuildSettings_Offset), 0, ApplyBuildSettings_PropertyAddress.Address, ApplyBuildSettings);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RequestTangents_Offset), 0, RequestTangents_PropertyAddress.Address, RequestTangents);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreRemoveDegenerates_Offset), 0, IgnoreRemoveDegenerates_PropertyAddress.Address, IgnoreRemoveDegenerates);
	}

	public FGeometryScriptCopyMeshFromAssetOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCopyMeshFromAssetOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromAssetOptions");
			ApplyBuildSettings = false;
			RequestTangents = false;
			IgnoreRemoveDegenerates = false;
		}
		else
		{
			ApplyBuildSettings = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyBuildSettings_Offset), 0, ApplyBuildSettings_PropertyAddress.Address);
			RequestTangents = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RequestTangents_Offset), 0, RequestTangents_PropertyAddress.Address);
			IgnoreRemoveDegenerates = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreRemoveDegenerates_Offset), 0, IgnoreRemoveDegenerates_PropertyAddress.Address);
		}
	}

	static FGeometryScriptCopyMeshFromAssetOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptCopyMeshFromAssetOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptCopyMeshFromAssetOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromAssetOptions");
		FGeometryScriptCopyMeshFromAssetOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ApplyBuildSettings_PropertyAddress, intPtr, "bApplyBuildSettings");
		ApplyBuildSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyBuildSettings");
		ApplyBuildSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyBuildSettings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestTangents_PropertyAddress, intPtr, "bRequestTangents");
		RequestTangents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRequestTangents");
		RequestTangents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRequestTangents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreRemoveDegenerates_PropertyAddress, intPtr, "bIgnoreRemoveDegenerates");
		IgnoreRemoveDegenerates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreRemoveDegenerates");
		IgnoreRemoveDegenerates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreRemoveDegenerates", Classes.FBoolProperty);
		FGeometryScriptCopyMeshFromAssetOptions_IsValid = intPtr != IntPtr.Zero && ApplyBuildSettings_IsValid && RequestTangents_IsValid && IgnoreRemoveDegenerates_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromAssetOptions", FGeometryScriptCopyMeshFromAssetOptions_IsValid);
	}
}
