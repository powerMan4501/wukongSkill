using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkWwiseObjectDetails", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkWwiseObjectDetails
{
	private static bool ItemName_IsValid;

	private static int ItemName_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/AkAudio.AkWwiseObjectDetails:ItemName")]
	public string ItemName;

	private static bool ItemPath_IsValid;

	private static int ItemPath_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/AkAudio.AkWwiseObjectDetails:ItemPath")]
	public string ItemPath;

	private static bool ItemId_IsValid;

	private static int ItemId_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/AkAudio.AkWwiseObjectDetails:ItemId")]
	public string ItemId;

	private static bool FAkWwiseObjectDetails_IsValid;

	private static int FAkWwiseObjectDetails_StructSize;

	public FAkWwiseObjectDetails Copy()
	{
		return this;
	}

	public static FAkWwiseObjectDetails FromNative(IntPtr nativeBuffer)
	{
		return new FAkWwiseObjectDetails(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkWwiseObjectDetails value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkWwiseObjectDetails FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkWwiseObjectDetails(nativeBuffer + arrayIndex * FAkWwiseObjectDetails_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkWwiseObjectDetails value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkWwiseObjectDetails_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkWwiseObjectDetails_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkWwiseObjectDetails");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemName_Offset), ItemName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemPath_Offset), ItemPath);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemId_Offset), ItemId);
	}

	public FAkWwiseObjectDetails(IntPtr nativeStruct)
	{
		if (!FAkWwiseObjectDetails_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkWwiseObjectDetails");
			ItemName = FStringMarshaler.DefaultString;
			ItemPath = FStringMarshaler.DefaultString;
			ItemId = FStringMarshaler.DefaultString;
		}
		else
		{
			ItemName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ItemName_Offset));
			ItemPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ItemPath_Offset));
			ItemId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ItemId_Offset));
		}
	}

	static FAkWwiseObjectDetails()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkWwiseObjectDetails)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkWwiseObjectDetails));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkWwiseObjectDetails");
		FAkWwiseObjectDetails_StructSize = NativeReflection.GetStructSize(intPtr);
		ItemName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemName");
		ItemName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemName", Classes.FStrProperty);
		ItemPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemPath");
		ItemPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemPath", Classes.FStrProperty);
		ItemId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemId");
		ItemId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemId", Classes.FStrProperty);
		FAkWwiseObjectDetails_IsValid = intPtr != IntPtr.Zero && ItemName_IsValid && ItemPath_IsValid && ItemId_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkWwiseObjectDetails", FAkWwiseObjectDetails_IsValid);
	}
}
