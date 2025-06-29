using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SpecialBoneConfig")]
public class BGWDataAsset_SpecialBoneConfig : UBGWDataAsset
{
	private static bool UnitBP_IsValid;

	private static int UnitBP_Offset;

	private static bool SweepCheckBoneBlackList_IsValid;

	private static int SweepCheckBoneBlackList_Offset;

	private static FFieldAddress SweepCheckBoneBlackList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SweepCheckBoneBlackList_Marshaler;

	private static bool SweepCheckBoneWhiteList_IsValid;

	private static int SweepCheckBoneWhiteList_Offset;

	private static FFieldAddress SweepCheckBoneWhiteList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SweepCheckBoneWhiteList_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Unit")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpecialBoneConfig:UnitBP")]
	public TSubclassOf<BGUCharacterCS> UnitBP
	{
		get
		{
			CheckDestroyed();
			if (!UnitBP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpecialBoneConfig:UnitBP");
				return default(TSubclassOf<BGUCharacterCS>);
			}
			return TSubclassOfMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, UnitBP_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitBP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpecialBoneConfig:UnitBP");
			}
			else
			{
				TSubclassOfMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, UnitBP_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SweepCheck")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpecialBoneConfig:SweepCheckBoneBlackList")]
	public TArrayReadWrite<FName> SweepCheckBoneBlackList
	{
		get
		{
			CheckDestroyed();
			if (!SweepCheckBoneBlackList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpecialBoneConfig:SweepCheckBoneBlackList");
				return null;
			}
			if (SweepCheckBoneBlackList_Marshaler == null)
			{
				SweepCheckBoneBlackList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SweepCheckBoneBlackList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SweepCheckBoneBlackList_Marshaler.FromNative(IntPtr.Add(base.Address, SweepCheckBoneBlackList_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("SweepCheck")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SpecialBoneConfig:SweepCheckBoneWhiteList")]
	public TArrayReadWrite<FName> SweepCheckBoneWhiteList
	{
		get
		{
			CheckDestroyed();
			if (!SweepCheckBoneWhiteList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SpecialBoneConfig:SweepCheckBoneWhiteList");
				return null;
			}
			if (SweepCheckBoneWhiteList_Marshaler == null)
			{
				SweepCheckBoneWhiteList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SweepCheckBoneWhiteList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SweepCheckBoneWhiteList_Marshaler.FromNative(IntPtr.Add(base.Address, SweepCheckBoneWhiteList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SpecialBoneConfig");
		UnitBP_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitBP");
		UnitBP_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitBP", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref SweepCheckBoneBlackList_PropertyAddress, unrealStruct, "SweepCheckBoneBlackList");
		SweepCheckBoneBlackList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SweepCheckBoneBlackList");
		SweepCheckBoneBlackList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SweepCheckBoneBlackList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SweepCheckBoneWhiteList_PropertyAddress, unrealStruct, "SweepCheckBoneWhiteList");
		SweepCheckBoneWhiteList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SweepCheckBoneWhiteList");
		SweepCheckBoneWhiteList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SweepCheckBoneWhiteList", Classes.FArrayProperty);
	}

	static BGWDataAsset_SpecialBoneConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SpecialBoneConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SpecialBoneConfig));
	}
}
