using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SkillIDBlackListConfig")]
public class BGWDataAsset_SkillIDBlackListConfig : UBGWDataAsset
{
	private static bool SkillList_IsValid;

	private static int SkillList_Offset;

	private static FFieldAddress SkillList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SkillList_Marshaler;

	[Tooltip("SKillID黑名单")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SkillIDBlackListConfig:SkillList")]
	public TArrayReadWrite<int> SkillList
	{
		get
		{
			CheckDestroyed();
			if (!SkillList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SkillIDBlackListConfig:SkillList");
				return null;
			}
			if (SkillList_Marshaler == null)
			{
				SkillList_Marshaler = new TArrayReadWriteMarshaler<int>(1, SkillList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SkillList_Marshaler.FromNative(IntPtr.Add(base.Address, SkillList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SkillIDBlackListConfig");
		NativeReflection.GetPropertyRef(ref SkillList_PropertyAddress, unrealStruct, "SkillList");
		SkillList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillList");
		SkillList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillList", Classes.FArrayProperty);
	}

	static BGWDataAsset_SkillIDBlackListConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SkillIDBlackListConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SkillIDBlackListConfig));
	}
}
