using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AssetRegistry;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AssetRegistry.AssetRegistryDependencyOptions", "AssetRegistry", UnrealModuleType.Engine)]
public struct FAssetRegistryDependencyOptions
{
	private static bool IncludeSoftPackageReferences_IsValid;

	private static FFieldAddress IncludeSoftPackageReferences_PropertyAddress;

	private static int IncludeSoftPackageReferences_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryDependencyOptions:bIncludeSoftPackageReferences")]
	public bool IncludeSoftPackageReferences;

	private static bool IncludeHardPackageReferences_IsValid;

	private static FFieldAddress IncludeHardPackageReferences_PropertyAddress;

	private static int IncludeHardPackageReferences_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryDependencyOptions:bIncludeHardPackageReferences")]
	public bool IncludeHardPackageReferences;

	private static bool IncludeSearchableNames_IsValid;

	private static FFieldAddress IncludeSearchableNames_PropertyAddress;

	private static int IncludeSearchableNames_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryDependencyOptions:bIncludeSearchableNames")]
	public bool IncludeSearchableNames;

	private static bool IncludeSoftManagementReferences_IsValid;

	private static FFieldAddress IncludeSoftManagementReferences_PropertyAddress;

	private static int IncludeSoftManagementReferences_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryDependencyOptions:bIncludeSoftManagementReferences")]
	public bool IncludeSoftManagementReferences;

	private static bool IncludeHardManagementReferences_IsValid;

	private static FFieldAddress IncludeHardManagementReferences_PropertyAddress;

	private static int IncludeHardManagementReferences_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistryDependencyOptions:bIncludeHardManagementReferences")]
	public bool IncludeHardManagementReferences;

	private static bool FAssetRegistryDependencyOptions_IsValid;

	private static int FAssetRegistryDependencyOptions_StructSize;

	public FAssetRegistryDependencyOptions Copy()
	{
		return this;
	}

	public static FAssetRegistryDependencyOptions FromNative(IntPtr nativeBuffer)
	{
		return new FAssetRegistryDependencyOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAssetRegistryDependencyOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAssetRegistryDependencyOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAssetRegistryDependencyOptions(nativeBuffer + arrayIndex * FAssetRegistryDependencyOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAssetRegistryDependencyOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAssetRegistryDependencyOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAssetRegistryDependencyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AssetRegistry.AssetRegistryDependencyOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeSoftPackageReferences_Offset), 0, IncludeSoftPackageReferences_PropertyAddress.Address, IncludeSoftPackageReferences);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeHardPackageReferences_Offset), 0, IncludeHardPackageReferences_PropertyAddress.Address, IncludeHardPackageReferences);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeSearchableNames_Offset), 0, IncludeSearchableNames_PropertyAddress.Address, IncludeSearchableNames);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeSoftManagementReferences_Offset), 0, IncludeSoftManagementReferences_PropertyAddress.Address, IncludeSoftManagementReferences);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeHardManagementReferences_Offset), 0, IncludeHardManagementReferences_PropertyAddress.Address, IncludeHardManagementReferences);
	}

	public FAssetRegistryDependencyOptions(IntPtr nativeStruct)
	{
		if (!FAssetRegistryDependencyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AssetRegistry.AssetRegistryDependencyOptions");
			IncludeSoftPackageReferences = false;
			IncludeHardPackageReferences = false;
			IncludeSearchableNames = false;
			IncludeSoftManagementReferences = false;
			IncludeHardManagementReferences = false;
		}
		else
		{
			IncludeSoftPackageReferences = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeSoftPackageReferences_Offset), 0, IncludeSoftPackageReferences_PropertyAddress.Address);
			IncludeHardPackageReferences = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeHardPackageReferences_Offset), 0, IncludeHardPackageReferences_PropertyAddress.Address);
			IncludeSearchableNames = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeSearchableNames_Offset), 0, IncludeSearchableNames_PropertyAddress.Address);
			IncludeSoftManagementReferences = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeSoftManagementReferences_Offset), 0, IncludeSoftManagementReferences_PropertyAddress.Address);
			IncludeHardManagementReferences = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeHardManagementReferences_Offset), 0, IncludeHardManagementReferences_PropertyAddress.Address);
		}
	}

	static FAssetRegistryDependencyOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAssetRegistryDependencyOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAssetRegistryDependencyOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AssetRegistry.AssetRegistryDependencyOptions");
		FAssetRegistryDependencyOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IncludeSoftPackageReferences_PropertyAddress, intPtr, "bIncludeSoftPackageReferences");
		IncludeSoftPackageReferences_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeSoftPackageReferences");
		IncludeSoftPackageReferences_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeSoftPackageReferences", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeHardPackageReferences_PropertyAddress, intPtr, "bIncludeHardPackageReferences");
		IncludeHardPackageReferences_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeHardPackageReferences");
		IncludeHardPackageReferences_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeHardPackageReferences", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeSearchableNames_PropertyAddress, intPtr, "bIncludeSearchableNames");
		IncludeSearchableNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeSearchableNames");
		IncludeSearchableNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeSearchableNames", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeSoftManagementReferences_PropertyAddress, intPtr, "bIncludeSoftManagementReferences");
		IncludeSoftManagementReferences_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeSoftManagementReferences");
		IncludeSoftManagementReferences_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeSoftManagementReferences", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeHardManagementReferences_PropertyAddress, intPtr, "bIncludeHardManagementReferences");
		IncludeHardManagementReferences_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeHardManagementReferences");
		IncludeHardManagementReferences_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeHardManagementReferences", Classes.FBoolProperty);
		FAssetRegistryDependencyOptions_IsValid = intPtr != IntPtr.Zero && IncludeSoftPackageReferences_IsValid && IncludeHardPackageReferences_IsValid && IncludeSearchableNames_IsValid && IncludeSoftManagementReferences_IsValid && IncludeHardManagementReferences_IsValid;
		NativeReflection.LogStructIsValid("/Script/AssetRegistry.AssetRegistryDependencyOptions", FAssetRegistryDependencyOptions_IsValid);
	}
}
