using System;
using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PerformerTriggerSkillEffect")]
public class MovieNodeInstance_PerformerTriggerSkillEffect : MovieNodeInstance
{
	private MovieCustom_PerformerTriggerSkillEffect CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PerformerTriggerSkillEffect();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(this, CustomData.PerformerGuid) as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			LogError("未找到Guid为" + CustomData.PerformerGuid + "的演员");
		}
		else
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				FEffectInstReq fEffectInstReq = new FEffectInstReq(bGUCharacterCS);
				fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
				fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUCharacterCS);
				fEffectInstReq.HitActionDir = EHitActionDir.Default;
				FEffectInstReq effectInstReq = fEffectInstReq;
				bUS_GSEventCollection.Evt_TriggerSkillEffect.Invoke(CustomData.SkillEffectId, effectInstReq);
			}
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PerformerTriggerSkillEffect");
	}

	static MovieNodeInstance_PerformerTriggerSkillEffect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PerformerTriggerSkillEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PerformerTriggerSkillEffect));
	}
}
