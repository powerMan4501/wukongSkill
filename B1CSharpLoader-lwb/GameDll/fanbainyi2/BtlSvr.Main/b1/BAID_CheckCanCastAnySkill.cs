using System;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckCanCastAnySkill")]
internal class BAID_CheckCanCastAnySkill : BAID_Base
{
	private static bool Skills_IsValid;

	private static int Skills_Offset;

	private static FFieldAddress Skills_PropertyAddress;

	private TArrayReadWriteMarshaler<int> Skills_Marshaler;

	[Category("Skill Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckCanCastAnySkill:Skills")]
	public TArrayReadWrite<int> Skills
	{
		get
		{
			CheckDestroyed();
			if (!Skills_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCanCastAnySkill:Skills");
				return null;
			}
			if (Skills_Marshaler == null)
			{
				Skills_Marshaler = new TArrayReadWriteMarshaler<int>(1, Skills_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return Skills_Marshaler.FromNative(IntPtr.Add(base.Address, Skills_Offset));
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(OwnerActor);
		if (aActor == null)
		{
			return false;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerActor);
		foreach (int skill in Skills)
		{
			int num = BGUFuncLibSkillCS.BGUGetSkillIDByMapping(OwnerActor, skill);
			FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(num);
			if (skillAIDesc != null)
			{
				float num2 = fVector.Size2D();
				if (!(num2 < skillAIDesc.PreferRangeMin) && !(skillAIDesc.PreferRangeMax < num2) && !(skillAIDesc.PreferHeightDis < fVector.Z) && BGU_CommonUtil.CheckSkillCanCast(OwnerActor, skill, num) == ECanCastSkillResult.CCSR_OK)
				{
					return true;
				}
			}
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckCanCastAnySkill");
		NativeReflection.GetPropertyRef(ref Skills_PropertyAddress, unrealStruct, "Skills");
		Skills_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Skills");
		Skills_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Skills", Classes.FArrayProperty);
	}

	static BAID_CheckCanCastAnySkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckCanCastAnySkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckCanCastAnySkill));
	}
}
