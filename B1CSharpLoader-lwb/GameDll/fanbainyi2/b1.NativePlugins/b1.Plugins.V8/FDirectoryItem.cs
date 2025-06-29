using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/V8.DirectoryItem", "V8", UnrealModuleType.GamePlugin)]
public struct FDirectoryItem
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/V8.DirectoryItem:Name")]
	public string Name;

	private static bool IsDirectory_IsValid;

	private static FFieldAddress IsDirectory_PropertyAddress;

	private static int IsDirectory_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/V8.DirectoryItem:bIsDirectory")]
	public bool IsDirectory;

	private static bool FDirectoryItem_IsValid;

	private static int FDirectoryItem_StructSize;

	public FDirectoryItem Copy()
	{
		return this;
	}

	public static FDirectoryItem FromNative(IntPtr nativeBuffer)
	{
		return new FDirectoryItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDirectoryItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDirectoryItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDirectoryItem(nativeBuffer + arrayIndex * FDirectoryItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDirectoryItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDirectoryItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDirectoryItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.DirectoryItem");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsDirectory_Offset), 0, IsDirectory_PropertyAddress.Address, IsDirectory);
	}

	public FDirectoryItem(IntPtr nativeStruct)
	{
		if (!FDirectoryItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.DirectoryItem");
			Name = FStringMarshaler.DefaultString;
			IsDirectory = false;
		}
		else
		{
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			IsDirectory = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsDirectory_Offset), 0, IsDirectory_PropertyAddress.Address);
		}
	}

	static FDirectoryItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDirectoryItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDirectoryItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.DirectoryItem");
		FDirectoryItem_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectory_PropertyAddress, intPtr, "bIsDirectory");
		IsDirectory_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsDirectory");
		IsDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsDirectory", Classes.FBoolProperty);
		FDirectoryItem_IsValid = intPtr != IntPtr.Zero && Name_IsValid && IsDirectory_IsValid;
		NativeReflection.LogStructIsValid("/Script/V8.DirectoryItem", FDirectoryItem_IsValid);
	}
}
