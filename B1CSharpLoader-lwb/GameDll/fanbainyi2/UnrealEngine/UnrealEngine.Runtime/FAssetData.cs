using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 4107)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.AssetData", "CoreUObject", UnrealModuleType.Engine)]
public struct FAssetData
{
	private static bool ObjectPath_IsValid;

	private static int ObjectPath_Offset;

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/CoreUObject.AssetData:ObjectPath")]
	public FName ObjectPath;

	private static bool PackageName_IsValid;

	private static int PackageName_Offset;

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/CoreUObject.AssetData:PackageName")]
	public FName PackageName;

	private static bool PackagePath_IsValid;

	private static int PackagePath_Offset;

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/CoreUObject.AssetData:PackagePath")]
	public FName PackagePath;

	private static bool AssetName_IsValid;

	private static int AssetName_Offset;

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/CoreUObject.AssetData:AssetName")]
	public FName AssetName;

	private static bool AssetClass_IsValid;

	private static int AssetClass_Offset;

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/CoreUObject.AssetData:AssetClass")]
	public FName AssetClass;

	private static bool FAssetData_IsValid;

	private static int FAssetData_StructSize;

	public FAssetData Copy()
	{
		return this;
	}

	public static FAssetData FromNative(IntPtr nativeBuffer)
	{
		return new FAssetData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAssetData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAssetData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAssetData(nativeBuffer + arrayIndex * FAssetData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAssetData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAssetData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAssetData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.AssetData");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ObjectPath_Offset), ObjectPath);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, PackageName_Offset), PackageName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, PackagePath_Offset), PackagePath);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AssetName_Offset), AssetName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AssetClass_Offset), AssetClass);
	}

	public FAssetData(IntPtr nativeStruct)
	{
		if (!FAssetData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.AssetData");
			ObjectPath = default(FName);
			PackageName = default(FName);
			PackagePath = default(FName);
			AssetName = default(FName);
			AssetClass = default(FName);
		}
		else
		{
			ObjectPath = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ObjectPath_Offset));
			PackageName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, PackageName_Offset));
			PackagePath = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, PackagePath_Offset));
			AssetName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AssetName_Offset));
			AssetClass = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AssetClass_Offset));
		}
	}

	static FAssetData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAssetData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAssetData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.AssetData");
		FAssetData_StructSize = NativeReflection.GetStructSize(intPtr);
		ObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObjectPath");
		ObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObjectPath", Classes.FNameProperty);
		PackageName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PackageName");
		PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PackageName", Classes.FNameProperty);
		PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PackagePath");
		PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PackagePath", Classes.FNameProperty);
		AssetName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssetName");
		AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssetName", Classes.FNameProperty);
		AssetClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssetClass");
		AssetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssetClass", Classes.FNameProperty);
		FAssetData_IsValid = intPtr != IntPtr.Zero && ObjectPath_IsValid && PackageName_IsValid && PackagePath_IsValid && AssetName_IsValid && AssetClass_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.AssetData", FAssetData_IsValid);
	}
}
