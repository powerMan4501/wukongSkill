using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkWwiseItemToControl", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkWwiseItemToControl
{
	private static bool ItemPath_IsValid;

	private static int ItemPath_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/AkAudio.AkWwiseItemToControl:ItemPath")]
	public string ItemPath;

	private static bool FAkWwiseItemToControl_IsValid;

	private static int FAkWwiseItemToControl_StructSize;

	public FAkWwiseItemToControl Copy()
	{
		return this;
	}

	public static FAkWwiseItemToControl FromNative(IntPtr nativeBuffer)
	{
		return new FAkWwiseItemToControl(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkWwiseItemToControl value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkWwiseItemToControl FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkWwiseItemToControl(nativeBuffer + arrayIndex * FAkWwiseItemToControl_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkWwiseItemToControl value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkWwiseItemToControl_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkWwiseItemToControl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkWwiseItemToControl");
		}
		else
		{
			FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemPath_Offset), ItemPath);
		}
	}

	public FAkWwiseItemToControl(IntPtr nativeStruct)
	{
		if (!FAkWwiseItemToControl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkWwiseItemToControl");
			ItemPath = FStringMarshaler.DefaultString;
		}
		else
		{
			ItemPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ItemPath_Offset));
		}
	}

	static FAkWwiseItemToControl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkWwiseItemToControl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkWwiseItemToControl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkWwiseItemToControl");
		FAkWwiseItemToControl_StructSize = NativeReflection.GetStructSize(intPtr);
		ItemPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemPath");
		ItemPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemPath", Classes.FStrProperty);
		FAkWwiseItemToControl_IsValid = intPtr != IntPtr.Zero && ItemPath_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkWwiseItemToControl", FAkWwiseItemToControl_IsValid);
	}
}
