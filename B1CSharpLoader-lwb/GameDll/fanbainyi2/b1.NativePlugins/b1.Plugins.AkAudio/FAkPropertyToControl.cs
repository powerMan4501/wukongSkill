using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkPropertyToControl", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkPropertyToControl
{
	private static bool ItemProperty_IsValid;

	private static int ItemProperty_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/AkAudio.AkPropertyToControl:ItemProperty")]
	public string ItemProperty;

	private static bool FAkPropertyToControl_IsValid;

	private static int FAkPropertyToControl_StructSize;

	public FAkPropertyToControl Copy()
	{
		return this;
	}

	public static FAkPropertyToControl FromNative(IntPtr nativeBuffer)
	{
		return new FAkPropertyToControl(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkPropertyToControl value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkPropertyToControl FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkPropertyToControl(nativeBuffer + arrayIndex * FAkPropertyToControl_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkPropertyToControl value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkPropertyToControl_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkPropertyToControl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkPropertyToControl");
		}
		else
		{
			FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemProperty_Offset), ItemProperty);
		}
	}

	public FAkPropertyToControl(IntPtr nativeStruct)
	{
		if (!FAkPropertyToControl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkPropertyToControl");
			ItemProperty = FStringMarshaler.DefaultString;
		}
		else
		{
			ItemProperty = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ItemProperty_Offset));
		}
	}

	static FAkPropertyToControl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkPropertyToControl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkPropertyToControl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkPropertyToControl");
		FAkPropertyToControl_StructSize = NativeReflection.GetStructSize(intPtr);
		ItemProperty_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemProperty");
		ItemProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemProperty", Classes.FStrProperty);
		FAkPropertyToControl_IsValid = intPtr != IntPtr.Zero && ItemProperty_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkPropertyToControl", FAkPropertyToControl_IsValid);
	}
}
