using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_TamerAndBulletSkillIDConfig")]
public class BGWDataAsset_TamerAndBulletSkillIDConfig : UBGWDataAsset
{
	private static bool BulletSkillTestInfos_IsValid;

	private static int BulletSkillTestInfos_Offset;

	private static FFieldAddress BulletSkillTestInfos_PropertyAddress;

	private TArrayReadWriteMarshaler<BulletSkillTestInfo> BulletSkillTestInfos_Marshaler;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TamerAndBulletSkillIDConfig:BulletSkillTestInfos")]
	public TArrayReadWrite<BulletSkillTestInfo> BulletSkillTestInfos
	{
		get
		{
			CheckDestroyed();
			if (!BulletSkillTestInfos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TamerAndBulletSkillIDConfig:BulletSkillTestInfos");
				return null;
			}
			if (BulletSkillTestInfos_Marshaler == null)
			{
				BulletSkillTestInfos_Marshaler = new TArrayReadWriteMarshaler<BulletSkillTestInfo>(1, BulletSkillTestInfos_PropertyAddress, CachedMarshalingDelegates<BulletSkillTestInfo, BulletSkillTestInfo>.FromNative, CachedMarshalingDelegates<BulletSkillTestInfo, BulletSkillTestInfo>.ToNative);
			}
			return BulletSkillTestInfos_Marshaler.FromNative(IntPtr.Add(base.Address, BulletSkillTestInfos_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_TamerAndBulletSkillIDConfig");
		NativeReflection.GetPropertyRef(ref BulletSkillTestInfos_PropertyAddress, unrealStruct, "BulletSkillTestInfos");
		BulletSkillTestInfos_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BulletSkillTestInfos");
		BulletSkillTestInfos_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BulletSkillTestInfos", Classes.FArrayProperty);
	}

	static BGWDataAsset_TamerAndBulletSkillIDConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_TamerAndBulletSkillIDConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_TamerAndBulletSkillIDConfig));
	}
}
