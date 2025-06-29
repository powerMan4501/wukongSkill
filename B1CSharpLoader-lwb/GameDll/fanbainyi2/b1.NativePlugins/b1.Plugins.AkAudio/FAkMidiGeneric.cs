using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMidiGeneric", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkMidiGeneric
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

	private static bool Param1_IsValid;

	private static int Param1_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiGeneric:Param1")]
	public byte Param1;

	private static bool Param2_IsValid;

	private static int Param2_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiGeneric:Param2")]
	public byte Param2;

	private static bool FAkMidiGeneric_IsValid;

	private static int FAkMidiGeneric_StructSize;

	public FAkMidiGeneric Copy()
	{
		return this;
	}

	public static FAkMidiGeneric FromNative(IntPtr nativeBuffer)
	{
		return new FAkMidiGeneric(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkMidiGeneric value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkMidiGeneric FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkMidiGeneric(nativeBuffer + arrayIndex * FAkMidiGeneric_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkMidiGeneric value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkMidiGeneric_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkMidiGeneric_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiGeneric");
			return;
		}
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Param1_Offset), Param1);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Param2_Offset), Param2);
		EnumMarshaler<EAkMidiEventType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Chan_Offset), Chan);
	}

	public FAkMidiGeneric(IntPtr nativeStruct)
	{
		if (!FAkMidiGeneric_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiGeneric");
			Param1 = 0;
			Param2 = 0;
			Type = EAkMidiEventType.AkMidiEventTypeInvalid;
			Chan = 0;
		}
		else
		{
			Param1 = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Param1_Offset));
			Param2 = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Param2_Offset));
			Type = EnumMarshaler<EAkMidiEventType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Chan = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Chan_Offset));
		}
	}

	static FAkMidiGeneric()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkMidiGeneric)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkMidiGeneric));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkMidiGeneric");
		FAkMidiGeneric_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		Chan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Chan");
		Chan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Chan", Classes.FByteProperty);
		Param1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Param1");
		Param1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Param1", Classes.FByteProperty);
		Param2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Param2");
		Param2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Param2", Classes.FByteProperty);
		FAkMidiGeneric_IsValid = intPtr != IntPtr.Zero && Param1_IsValid && Param2_IsValid && Type_IsValid && Chan_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkMidiGeneric", FAkMidiGeneric_IsValid);
	}
}
