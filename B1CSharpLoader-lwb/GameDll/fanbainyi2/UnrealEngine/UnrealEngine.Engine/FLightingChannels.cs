using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.LightingChannels", "Engine", UnrealModuleType.Engine)]
public struct FLightingChannels
{
	private static bool Channel0_IsValid;

	private static FFieldAddress Channel0_PropertyAddress;

	private static int Channel0_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.LightingChannels:bChannel0")]
	public bool Channel0;

	private static bool Channel1_IsValid;

	private static FFieldAddress Channel1_PropertyAddress;

	private static int Channel1_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.LightingChannels:bChannel1")]
	public bool Channel1;

	private static bool Channel2_IsValid;

	private static FFieldAddress Channel2_PropertyAddress;

	private static int Channel2_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.LightingChannels:bChannel2")]
	public bool Channel2;

	private static bool FLightingChannels_IsValid;

	private static int FLightingChannels_StructSize;

	public FLightingChannels Copy()
	{
		return this;
	}

	public static FLightingChannels FromNative(IntPtr nativeBuffer)
	{
		return new FLightingChannels(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLightingChannels value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLightingChannels FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLightingChannels(nativeBuffer + arrayIndex * FLightingChannels_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLightingChannels value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLightingChannels_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLightingChannels_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LightingChannels");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Channel0_Offset), 0, Channel0_PropertyAddress.Address, Channel0);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Channel1_Offset), 0, Channel1_PropertyAddress.Address, Channel1);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Channel2_Offset), 0, Channel2_PropertyAddress.Address, Channel2);
	}

	public FLightingChannels(IntPtr nativeStruct)
	{
		if (!FLightingChannels_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LightingChannels");
			Channel0 = false;
			Channel1 = false;
			Channel2 = false;
		}
		else
		{
			Channel0 = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Channel0_Offset), 0, Channel0_PropertyAddress.Address);
			Channel1 = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Channel1_Offset), 0, Channel1_PropertyAddress.Address);
			Channel2 = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Channel2_Offset), 0, Channel2_PropertyAddress.Address);
		}
	}

	static FLightingChannels()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLightingChannels)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLightingChannels));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.LightingChannels");
		FLightingChannels_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Channel0_PropertyAddress, intPtr, "bChannel0");
		Channel0_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bChannel0");
		Channel0_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bChannel0", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Channel1_PropertyAddress, intPtr, "bChannel1");
		Channel1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bChannel1");
		Channel1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bChannel1", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Channel2_PropertyAddress, intPtr, "bChannel2");
		Channel2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bChannel2");
		Channel2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bChannel2", Classes.FBoolProperty);
		FLightingChannels_IsValid = intPtr != IntPtr.Zero && Channel0_IsValid && Channel1_IsValid && Channel2_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.LightingChannels", FLightingChannels_IsValid);
	}
}
