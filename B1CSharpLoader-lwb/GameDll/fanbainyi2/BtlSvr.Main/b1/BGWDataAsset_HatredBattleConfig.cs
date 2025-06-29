using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_HatredBattleConfig")]
public class BGWDataAsset_HatredBattleConfig : UBGWDataAsset
{
	private static bool HatredBattleBlackList_IsValid;

	private static int HatredBattleBlackList_Offset;

	private static FFieldAddress HatredBattleBlackList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> HatredBattleBlackList_Marshaler;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_HatredBattleConfig:HatredBattleBlackList")]
	public TArrayReadWrite<int> HatredBattleBlackList
	{
		get
		{
			CheckDestroyed();
			if (!HatredBattleBlackList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HatredBattleConfig:HatredBattleBlackList");
				return null;
			}
			if (HatredBattleBlackList_Marshaler == null)
			{
				HatredBattleBlackList_Marshaler = new TArrayReadWriteMarshaler<int>(1, HatredBattleBlackList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return HatredBattleBlackList_Marshaler.FromNative(IntPtr.Add(base.Address, HatredBattleBlackList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_HatredBattleConfig");
		NativeReflection.GetPropertyRef(ref HatredBattleBlackList_PropertyAddress, unrealStruct, "HatredBattleBlackList");
		HatredBattleBlackList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HatredBattleBlackList");
		HatredBattleBlackList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HatredBattleBlackList", Classes.FArrayProperty);
	}

	static BGWDataAsset_HatredBattleConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_HatredBattleConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_HatredBattleConfig));
	}
}
