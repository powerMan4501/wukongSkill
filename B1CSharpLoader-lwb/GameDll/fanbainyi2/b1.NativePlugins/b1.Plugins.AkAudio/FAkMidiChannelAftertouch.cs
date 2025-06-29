using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMidiChannelAftertouch", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkMidiChannelAftertouch
{
	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiEventBase:Type")]
	public EAkMidiEventType Type;

	private static bool Chan_IsValid;

	private static int Chan_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiEventBase:Chan")]
	public byte Chan;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiChannelAftertouch:Value")]
	public byte Value;

	private static bool FAkMidiChannelAftertouch_IsValid;

	private static int FAkMidiChannelAftertouch_StructSize;

	public FAkMidiChannelAftertouch Copy()
	{
		return this;
	}

	public static FAkMidiChannelAftertouch FromNative(IntPtr nativeBuffer)
	{
		return new FAkMidiChannelAftertouch(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkMidiChannelAftertouch value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkMidiChannelAftertouch FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkMidiChannelAftertouch(nativeBuffer + arrayIndex * FAkMidiChannelAftertouch_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkMidiChannelAftertouch value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkMidiChannelAftertouch_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkMidiChannelAftertouch_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiChannelAftertouch");
			return;
		}
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		EnumMarshaler<EAkMidiEventType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Chan_Offset), Chan);
	}

	public FAkMidiChannelAftertouch(IntPtr nativeStruct)
	{
		if (!FAkMidiChannelAftertouch_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiChannelAftertouch");
			Value = 0;
			Type = EAkMidiEventType.AkMidiEventTypeInvalid;
			Chan = 0;
		}
		else
		{
			Value = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Type = EnumMarshaler<EAkMidiEventType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Chan = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Chan_Offset));
		}
	}

	static FAkMidiChannelAftertouch()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkMidiChannelAftertouch)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkMidiChannelAftertouch));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkMidiChannelAftertouch");
		FAkMidiChannelAftertouch_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		Chan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Chan");
		Chan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Chan", Classes.FByteProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FByteProperty);
		FAkMidiChannelAftertouch_IsValid = intPtr != IntPtr.Zero && Value_IsValid && Type_IsValid && Chan_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkMidiChannelAftertouch", FAkMidiChannelAftertouch_IsValid);
	}
}
