using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWHeroIconConfigDataAsset")]
public class BGWHeroIconConfigDataAsset : UBGWDataAsset
{
	private static bool HeroIconInfoList_IsValid;

	private static int HeroIconInfoList_Offset;

	private static FFieldAddress HeroIconInfoList_PropertyAddress;

	private TArrayReadWriteMarshaler<FHeroIconInfo> HeroIconInfoList_Marshaler;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWHeroIconConfigDataAsset:HeroIconInfoList")]
	public TArrayReadWrite<FHeroIconInfo> HeroIconInfoList
	{
		get
		{
			CheckDestroyed();
			if (!HeroIconInfoList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHeroIconConfigDataAsset:HeroIconInfoList");
				return null;
			}
			if (HeroIconInfoList_Marshaler == null)
			{
				HeroIconInfoList_Marshaler = new TArrayReadWriteMarshaler<FHeroIconInfo>(1, HeroIconInfoList_PropertyAddress, CachedMarshalingDelegates<FHeroIconInfo, FHeroIconInfo>.FromNative, CachedMarshalingDelegates<FHeroIconInfo, FHeroIconInfo>.ToNative);
			}
			return HeroIconInfoList_Marshaler.FromNative(IntPtr.Add(base.Address, HeroIconInfoList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWHeroIconConfigDataAsset");
		NativeReflection.GetPropertyRef(ref HeroIconInfoList_PropertyAddress, unrealStruct, "HeroIconInfoList");
		HeroIconInfoList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeroIconInfoList");
		HeroIconInfoList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeroIconInfoList", Classes.FArrayProperty);
	}

	static BGWHeroIconConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWHeroIconConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWHeroIconConfigDataAsset));
	}
}
