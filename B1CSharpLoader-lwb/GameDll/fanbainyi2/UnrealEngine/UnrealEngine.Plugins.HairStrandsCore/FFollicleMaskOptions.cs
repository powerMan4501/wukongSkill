using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.FollicleMaskOptions", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FFollicleMaskOptions
{
	private static bool Groom_IsValid;

	private static int Groom_Offset;

	[UProperty(Flags = (PropFlags)7881369141248517uL)]
	[UMetaPath("/Script/HairStrandsCore.FollicleMaskOptions:Groom")]
	public UGroomAsset Groom;

	private static bool Channel_IsValid;

	private static FFieldAddress Channel_PropertyAddress;

	private static int Channel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.FollicleMaskOptions:Channel")]
	public EFollicleMaskChannel Channel;

	private static bool FFollicleMaskOptions_IsValid;

	private static int FFollicleMaskOptions_StructSize;

	public FFollicleMaskOptions Copy()
	{
		return this;
	}

	public static FFollicleMaskOptions FromNative(IntPtr nativeBuffer)
	{
		return new FFollicleMaskOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFollicleMaskOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFollicleMaskOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFollicleMaskOptions(nativeBuffer + arrayIndex * FFollicleMaskOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFollicleMaskOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFollicleMaskOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFollicleMaskOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.FollicleMaskOptions");
			return;
		}
		UObjectMarshaler<UGroomAsset>.ToNative(IntPtr.Add(nativeStruct, Groom_Offset), Groom);
		EnumMarshaler<EFollicleMaskChannel>.ToNative(IntPtr.Add(nativeStruct, Channel_Offset), 0, Channel_PropertyAddress.Address, Channel);
	}

	public FFollicleMaskOptions(IntPtr nativeStruct)
	{
		if (!FFollicleMaskOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.FollicleMaskOptions");
			Groom = null;
			Channel = EFollicleMaskChannel.R;
		}
		else
		{
			Groom = UObjectMarshaler<UGroomAsset>.FromNative(IntPtr.Add(nativeStruct, Groom_Offset));
			Channel = EnumMarshaler<EFollicleMaskChannel>.FromNative(IntPtr.Add(nativeStruct, Channel_Offset), 0, Channel_PropertyAddress.Address);
		}
	}

	static FFollicleMaskOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFollicleMaskOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFollicleMaskOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.FollicleMaskOptions");
		FFollicleMaskOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		Groom_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Groom");
		Groom_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Groom", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Channel_PropertyAddress, intPtr, "Channel");
		Channel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Channel");
		Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Channel", Classes.FEnumProperty);
		FFollicleMaskOptions_IsValid = intPtr != IntPtr.Zero && Groom_IsValid && Channel_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.FollicleMaskOptions", FFollicleMaskOptions_IsValid);
	}
}
