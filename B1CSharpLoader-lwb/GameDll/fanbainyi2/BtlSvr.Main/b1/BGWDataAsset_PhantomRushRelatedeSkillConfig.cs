using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_PhantomRushRelatedeSkillConfig")]
public class BGWDataAsset_PhantomRushRelatedeSkillConfig : UBGWDataAsset
{
	private static bool PhantomRushAtkSkill_IsValid;

	private static int PhantomRushAtkSkill_Offset;

	private static FFieldAddress PhantomRushAtkSkill_PropertyAddress;

	private TArrayReadWriteMarshaler<int> PhantomRushAtkSkill_Marshaler;

	[UProperty]
	[EditAnywhere]
	[Category("Battle")]
	[DisplayName("可以破隐的技能列表")]
	[Tooltip("使用list里的技能会使主角退出聚形散气状态")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PhantomRushRelatedeSkillConfig:PhantomRushAtkSkill")]
	public TArrayReadWrite<int> PhantomRushAtkSkill
	{
		get
		{
			CheckDestroyed();
			if (!PhantomRushAtkSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PhantomRushRelatedeSkillConfig:PhantomRushAtkSkill");
				return null;
			}
			if (PhantomRushAtkSkill_Marshaler == null)
			{
				PhantomRushAtkSkill_Marshaler = new TArrayReadWriteMarshaler<int>(1, PhantomRushAtkSkill_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return PhantomRushAtkSkill_Marshaler.FromNative(IntPtr.Add(base.Address, PhantomRushAtkSkill_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_PhantomRushRelatedeSkillConfig");
		NativeReflection.GetPropertyRef(ref PhantomRushAtkSkill_PropertyAddress, unrealStruct, "PhantomRushAtkSkill");
		PhantomRushAtkSkill_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PhantomRushAtkSkill");
		PhantomRushAtkSkill_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PhantomRushAtkSkill", Classes.FArrayProperty);
	}

	static BGWDataAsset_PhantomRushRelatedeSkillConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_PhantomRushRelatedeSkillConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_PhantomRushRelatedeSkillConfig));
	}
}
