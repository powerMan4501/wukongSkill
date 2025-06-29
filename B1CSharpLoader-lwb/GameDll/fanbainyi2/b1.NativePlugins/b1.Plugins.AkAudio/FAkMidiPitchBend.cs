using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMidiPitchBend", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkMidiPitchBend
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

	private static bool ValueLsb_IsValid;

	private static int ValueLsb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiPitchBend:ValueLsb")]
	public byte ValueLsb;

	private static bool ValueMsb_IsValid;

	private static int ValueMsb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiPitchBend:ValueMsb")]
	public byte ValueMsb;

	private static bool FullValue_IsValid;

	private static int FullValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiPitchBend:FullValue")]
	public int FullValue;

	private static bool FAkMidiPitchBend_IsValid;

	private static int FAkMidiPitchBend_StructSize;

	public FAkMidiPitchBend Copy()
	{
		return this;
	}

	public static FAkMidiPitchBend FromNative(IntPtr nativeBuffer)
	{
		return new FAkMidiPitchBend(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkMidiPitchBend value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkMidiPitchBend FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkMidiPitchBend(nativeBuffer + arrayIndex * FAkMidiPitchBend_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkMidiPitchBend value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkMidiPitchBend_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkMidiPitchBend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiPitchBend");
			return;
		}
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, ValueLsb_Offset), ValueLsb);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, ValueMsb_Offset), ValueMsb);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FullValue_Offset), FullValue);
		EnumMarshaler<EAkMidiEventType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Chan_Offset), Chan);
	}

	public FAkMidiPitchBend(IntPtr nativeStruct)
	{
		if (!FAkMidiPitchBend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiPitchBend");
			ValueLsb = 0;
			ValueMsb = 0;
			FullValue = 0;
			Type = EAkMidiEventType.AkMidiEventTypeInvalid;
			Chan = 0;
		}
		else
		{
			ValueLsb = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, ValueLsb_Offset));
			ValueMsb = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, ValueMsb_Offset));
			FullValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FullValue_Offset));
			Type = EnumMarshaler<EAkMidiEventType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Chan = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Chan_Offset));
		}
	}

	static FAkMidiPitchBend()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkMidiPitchBend)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkMidiPitchBend));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkMidiPitchBend");
		FAkMidiPitchBend_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		Chan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Chan");
		Chan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Chan", Classes.FByteProperty);
		ValueLsb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValueLsb");
		ValueLsb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValueLsb", Classes.FByteProperty);
		ValueMsb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValueMsb");
		ValueMsb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValueMsb", Classes.FByteProperty);
		FullValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FullValue");
		FullValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FullValue", Classes.FIntProperty);
		FAkMidiPitchBend_IsValid = intPtr != IntPtr.Zero && ValueLsb_IsValid && ValueMsb_IsValid && FullValue_IsValid && Type_IsValid && Chan_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkMidiPitchBend", FAkMidiPitchBend_IsValid);
	}
}
