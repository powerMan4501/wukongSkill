using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMidiNoteAftertouch", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkMidiNoteAftertouch
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

	private static bool Note_IsValid;

	private static int Note_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiNoteAftertouch:Note")]
	public byte Note;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiNoteAftertouch:Value")]
	public byte Value;

	private static bool FAkMidiNoteAftertouch_IsValid;

	private static int FAkMidiNoteAftertouch_StructSize;

	public FAkMidiNoteAftertouch Copy()
	{
		return this;
	}

	public static FAkMidiNoteAftertouch FromNative(IntPtr nativeBuffer)
	{
		return new FAkMidiNoteAftertouch(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkMidiNoteAftertouch value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkMidiNoteAftertouch FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkMidiNoteAftertouch(nativeBuffer + arrayIndex * FAkMidiNoteAftertouch_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkMidiNoteAftertouch value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkMidiNoteAftertouch_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkMidiNoteAftertouch_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiNoteAftertouch");
			return;
		}
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Note_Offset), Note);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		EnumMarshaler<EAkMidiEventType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Chan_Offset), Chan);
	}

	public FAkMidiNoteAftertouch(IntPtr nativeStruct)
	{
		if (!FAkMidiNoteAftertouch_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiNoteAftertouch");
			Note = 0;
			Value = 0;
			Type = EAkMidiEventType.AkMidiEventTypeInvalid;
			Chan = 0;
		}
		else
		{
			Note = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Note_Offset));
			Value = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Type = EnumMarshaler<EAkMidiEventType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Chan = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Chan_Offset));
		}
	}

	static FAkMidiNoteAftertouch()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkMidiNoteAftertouch)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkMidiNoteAftertouch));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkMidiNoteAftertouch");
		FAkMidiNoteAftertouch_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		Chan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Chan");
		Chan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Chan", Classes.FByteProperty);
		Note_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Note");
		Note_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Note", Classes.FByteProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FByteProperty);
		FAkMidiNoteAftertouch_IsValid = intPtr != IntPtr.Zero && Note_IsValid && Value_IsValid && Type_IsValid && Chan_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkMidiNoteAftertouch", FAkMidiNoteAftertouch_IsValid);
	}
}
