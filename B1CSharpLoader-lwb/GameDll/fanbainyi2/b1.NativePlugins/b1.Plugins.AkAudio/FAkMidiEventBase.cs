using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMidiEventBase", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkMidiEventBase
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

	private static bool FAkMidiEventBase_IsValid;

	private static int FAkMidiEventBase_StructSize;

	public FAkMidiEventBase Copy()
	{
		return this;
	}

	public static FAkMidiEventBase FromNative(IntPtr nativeBuffer)
	{
		return new FAkMidiEventBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkMidiEventBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkMidiEventBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkMidiEventBase(nativeBuffer + arrayIndex * FAkMidiEventBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkMidiEventBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkMidiEventBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkMidiEventBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiEventBase");
			return;
		}
		EnumMarshaler<EAkMidiEventType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Chan_Offset), Chan);
	}

	public FAkMidiEventBase(IntPtr nativeStruct)
	{
		if (!FAkMidiEventBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiEventBase");
			Type = EAkMidiEventType.AkMidiEventTypeInvalid;
			Chan = 0;
		}
		else
		{
			Type = EnumMarshaler<EAkMidiEventType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Chan = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Chan_Offset));
		}
	}

	static FAkMidiEventBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkMidiEventBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkMidiEventBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkMidiEventBase");
		FAkMidiEventBase_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		Chan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Chan");
		Chan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Chan", Classes.FByteProperty);
		FAkMidiEventBase_IsValid = intPtr != IntPtr.Zero && Type_IsValid && Chan_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkMidiEventBase", FAkMidiEventBase_IsValid);
	}
}
