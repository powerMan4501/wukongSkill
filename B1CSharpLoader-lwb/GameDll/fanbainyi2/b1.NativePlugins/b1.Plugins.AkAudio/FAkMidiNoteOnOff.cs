using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMidiNoteOnOff", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkMidiNoteOnOff
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
	[UMetaPath("/Script/AkAudio.AkMidiNoteOnOff:Note")]
	public byte Note;

	private static bool Velocity_IsValid;

	private static int Velocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiNoteOnOff:Velocity")]
	public byte Velocity;

	private static bool FAkMidiNoteOnOff_IsValid;

	private static int FAkMidiNoteOnOff_StructSize;

	public FAkMidiNoteOnOff Copy()
	{
		return this;
	}

	public static FAkMidiNoteOnOff FromNative(IntPtr nativeBuffer)
	{
		return new FAkMidiNoteOnOff(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkMidiNoteOnOff value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkMidiNoteOnOff FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkMidiNoteOnOff(nativeBuffer + arrayIndex * FAkMidiNoteOnOff_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkMidiNoteOnOff value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkMidiNoteOnOff_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkMidiNoteOnOff_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiNoteOnOff");
			return;
		}
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Note_Offset), Note);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Velocity_Offset), Velocity);
		EnumMarshaler<EAkMidiEventType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Chan_Offset), Chan);
	}

	public FAkMidiNoteOnOff(IntPtr nativeStruct)
	{
		if (!FAkMidiNoteOnOff_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiNoteOnOff");
			Note = 0;
			Velocity = 0;
			Type = EAkMidiEventType.AkMidiEventTypeInvalid;
			Chan = 0;
		}
		else
		{
			Note = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Note_Offset));
			Velocity = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Velocity_Offset));
			Type = EnumMarshaler<EAkMidiEventType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Chan = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Chan_Offset));
		}
	}

	static FAkMidiNoteOnOff()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkMidiNoteOnOff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkMidiNoteOnOff));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkMidiNoteOnOff");
		FAkMidiNoteOnOff_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		Chan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Chan");
		Chan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Chan", Classes.FByteProperty);
		Note_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Note");
		Note_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Note", Classes.FByteProperty);
		Velocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Velocity");
		Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Velocity", Classes.FByteProperty);
		FAkMidiNoteOnOff_IsValid = intPtr != IntPtr.Zero && Note_IsValid && Velocity_IsValid && Type_IsValid && Chan_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkMidiNoteOnOff", FAkMidiNoteOnOff_IsValid);
	}
}
