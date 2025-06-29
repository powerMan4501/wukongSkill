using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkBoolPropertyToControl", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkBoolPropertyToControl
{
	private static bool ItemProperty_IsValid;

	private static int ItemProperty_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/AkAudio.AkBoolPropertyToControl:ItemProperty")]
	public string ItemProperty;

	private static bool FAkBoolPropertyToControl_IsValid;

	private static int FAkBoolPropertyToControl_StructSize;

	public FAkBoolPropertyToControl Copy()
	{
		return this;
	}

	public static FAkBoolPropertyToControl FromNative(IntPtr nativeBuffer)
	{
		return new FAkBoolPropertyToControl(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkBoolPropertyToControl value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkBoolPropertyToControl FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkBoolPropertyToControl(nativeBuffer + arrayIndex * FAkBoolPropertyToControl_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkBoolPropertyToControl value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkBoolPropertyToControl_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkBoolPropertyToControl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkBoolPropertyToControl");
		}
		else
		{
			FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemProperty_Offset), ItemProperty);
		}
	}

	public FAkBoolPropertyToControl(IntPtr nativeStruct)
	{
		if (!FAkBoolPropertyToControl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkBoolPropertyToControl");
			ItemProperty = FStringMarshaler.DefaultString;
		}
		else
		{
			ItemProperty = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ItemProperty_Offset));
		}
	}

	static FAkBoolPropertyToControl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkBoolPropertyToControl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkBoolPropertyToControl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkBoolPropertyToControl");
		FAkBoolPropertyToControl_StructSize = NativeReflection.GetStructSize(intPtr);
		ItemProperty_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemProperty");
		ItemProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemProperty", Classes.FStrProperty);
		FAkBoolPropertyToControl_IsValid = intPtr != IntPtr.Zero && ItemProperty_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkBoolPropertyToControl", FAkBoolPropertyToControl_IsValid);
	}
}
