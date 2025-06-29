using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AssetTools;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AssetTools.AssetRenameData", "AssetTools", UnrealModuleType.Engine)]
public struct FAssetRenameData
{
	private static bool Asset_IsValid;

	private static int Asset_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/AssetTools.AssetRenameData:Asset")]
	public TWeakObject<UObject> Asset;

	private static bool NewPackagePath_IsValid;

	private static int NewPackagePath_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/AssetTools.AssetRenameData:NewPackagePath")]
	public string NewPackagePath;

	private static bool NewName_IsValid;

	private static int NewName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/AssetTools.AssetRenameData:NewName")]
	public string NewName;

	private static bool FAssetRenameData_IsValid;

	private static int FAssetRenameData_StructSize;

	public FAssetRenameData Copy()
	{
		return this;
	}

	public static FAssetRenameData FromNative(IntPtr nativeBuffer)
	{
		return new FAssetRenameData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAssetRenameData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAssetRenameData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAssetRenameData(nativeBuffer + arrayIndex * FAssetRenameData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAssetRenameData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAssetRenameData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAssetRenameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AssetTools.AssetRenameData");
			return;
		}
		TWeakObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, Asset_Offset), Asset);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, NewPackagePath_Offset), NewPackagePath);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, NewName_Offset), NewName);
	}

	public FAssetRenameData(IntPtr nativeStruct)
	{
		if (!FAssetRenameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AssetTools.AssetRenameData");
			Asset = default(TWeakObject<UObject>);
			NewPackagePath = FStringMarshaler.DefaultString;
			NewName = FStringMarshaler.DefaultString;
		}
		else
		{
			Asset = TWeakObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, Asset_Offset));
			NewPackagePath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, NewPackagePath_Offset));
			NewName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, NewName_Offset));
		}
	}

	static FAssetRenameData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAssetRenameData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAssetRenameData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AssetTools.AssetRenameData");
		FAssetRenameData_StructSize = NativeReflection.GetStructSize(intPtr);
		Asset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Asset");
		Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Asset", Classes.FWeakObjectProperty);
		NewPackagePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewPackagePath");
		NewPackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewPackagePath", Classes.FStrProperty);
		NewName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewName");
		NewName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewName", Classes.FStrProperty);
		FAssetRenameData_IsValid = intPtr != IntPtr.Zero && Asset_IsValid && NewPackagePath_IsValid && NewName_IsValid;
		NativeReflection.LogStructIsValid("/Script/AssetTools.AssetRenameData", FAssetRenameData_IsValid);
	}
}
