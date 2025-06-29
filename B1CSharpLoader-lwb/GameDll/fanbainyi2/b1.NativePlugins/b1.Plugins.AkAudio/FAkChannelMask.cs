using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkChannelMask", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkChannelMask
{
	private static bool ChannelMask_IsValid;

	private static int ChannelMask_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkChannelMask:ChannelMask")]
	public int ChannelMask;

	private static bool FAkChannelMask_IsValid;

	private static int FAkChannelMask_StructSize;

	public FAkChannelMask Copy()
	{
		return this;
	}

	public static FAkChannelMask FromNative(IntPtr nativeBuffer)
	{
		return new FAkChannelMask(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkChannelMask value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkChannelMask FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkChannelMask(nativeBuffer + arrayIndex * FAkChannelMask_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkChannelMask value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkChannelMask_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkChannelMask_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkChannelMask");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ChannelMask_Offset), ChannelMask);
		}
	}

	public FAkChannelMask(IntPtr nativeStruct)
	{
		if (!FAkChannelMask_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkChannelMask");
			ChannelMask = 0;
		}
		else
		{
			ChannelMask = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ChannelMask_Offset));
		}
	}

	static FAkChannelMask()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkChannelMask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkChannelMask));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkChannelMask");
		FAkChannelMask_StructSize = NativeReflection.GetStructSize(intPtr);
		ChannelMask_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChannelMask");
		ChannelMask_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChannelMask", Classes.FIntProperty);
		FAkChannelMask_IsValid = intPtr != IntPtr.Zero && ChannelMask_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkChannelMask", FAkChannelMask_IsValid);
	}
}
