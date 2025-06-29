using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMidiCc", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkMidiCc
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

	private static bool Cc_IsValid;

	private static FFieldAddress Cc_PropertyAddress;

	private static int Cc_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiCc:Cc")]
	public EAkMidiCcValues Cc;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiCc:Value")]
	public byte Value;

	private static bool FAkMidiCc_IsValid;

	private static int FAkMidiCc_StructSize;

	public FAkMidiCc Copy()
	{
		return this;
	}

	public static FAkMidiCc FromNative(IntPtr nativeBuffer)
	{
		return new FAkMidiCc(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkMidiCc value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkMidiCc FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkMidiCc(nativeBuffer + arrayIndex * FAkMidiCc_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkMidiCc value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkMidiCc_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkMidiCc_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiCc");
			return;
		}
		EnumMarshaler<EAkMidiCcValues>.ToNative(IntPtr.Add(nativeStruct, Cc_Offset), 0, Cc_PropertyAddress.Address, Cc);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		EnumMarshaler<EAkMidiEventType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Chan_Offset), Chan);
	}

	public FAkMidiCc(IntPtr nativeStruct)
	{
		if (!FAkMidiCc_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiCc");
			Cc = EAkMidiCcValues.AkMidiCcBankSelectCoarse;
			Value = 0;
			Type = EAkMidiEventType.AkMidiEventTypeInvalid;
			Chan = 0;
		}
		else
		{
			Cc = EnumMarshaler<EAkMidiCcValues>.FromNative(IntPtr.Add(nativeStruct, Cc_Offset), 0, Cc_PropertyAddress.Address);
			Value = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Type = EnumMarshaler<EAkMidiEventType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Chan = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Chan_Offset));
		}
	}

	static FAkMidiCc()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkMidiCc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkMidiCc));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkMidiCc");
		FAkMidiCc_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		Chan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Chan");
		Chan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Chan", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Cc_PropertyAddress, intPtr, "Cc");
		Cc_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Cc");
		Cc_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Cc", Classes.FEnumProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FByteProperty);
		FAkMidiCc_IsValid = intPtr != IntPtr.Zero && Cc_IsValid && Value_IsValid && Type_IsValid && Chan_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkMidiCc", FAkMidiCc_IsValid);
	}
}
