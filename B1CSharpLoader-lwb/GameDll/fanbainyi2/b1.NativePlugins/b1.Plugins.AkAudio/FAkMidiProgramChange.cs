using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMidiProgramChange", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkMidiProgramChange
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

	private static bool ProgramNum_IsValid;

	private static int ProgramNum_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMidiProgramChange:ProgramNum")]
	public byte ProgramNum;

	private static bool FAkMidiProgramChange_IsValid;

	private static int FAkMidiProgramChange_StructSize;

	public FAkMidiProgramChange Copy()
	{
		return this;
	}

	public static FAkMidiProgramChange FromNative(IntPtr nativeBuffer)
	{
		return new FAkMidiProgramChange(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkMidiProgramChange value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkMidiProgramChange FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkMidiProgramChange(nativeBuffer + arrayIndex * FAkMidiProgramChange_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkMidiProgramChange value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkMidiProgramChange_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkMidiProgramChange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiProgramChange");
			return;
		}
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, ProgramNum_Offset), ProgramNum);
		EnumMarshaler<EAkMidiEventType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, Chan_Offset), Chan);
	}

	public FAkMidiProgramChange(IntPtr nativeStruct)
	{
		if (!FAkMidiProgramChange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkMidiProgramChange");
			ProgramNum = 0;
			Type = EAkMidiEventType.AkMidiEventTypeInvalid;
			Chan = 0;
		}
		else
		{
			ProgramNum = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, ProgramNum_Offset));
			Type = EnumMarshaler<EAkMidiEventType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Chan = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, Chan_Offset));
		}
	}

	static FAkMidiProgramChange()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkMidiProgramChange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkMidiProgramChange));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkMidiProgramChange");
		FAkMidiProgramChange_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		Chan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Chan");
		Chan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Chan", Classes.FByteProperty);
		ProgramNum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProgramNum");
		ProgramNum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProgramNum", Classes.FByteProperty);
		FAkMidiProgramChange_IsValid = intPtr != IntPtr.Zero && ProgramNum_IsValid && Type_IsValid && Chan_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkMidiProgramChange", FAkMidiProgramChange_IsValid);
	}
}
