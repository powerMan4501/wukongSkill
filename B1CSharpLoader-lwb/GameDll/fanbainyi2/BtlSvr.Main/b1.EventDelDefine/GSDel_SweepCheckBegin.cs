using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SweepCheckBegin : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SweepCheckBegin _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SweepCheckBegin)Delegate.Combine(_MultiCastDel, (Del_SweepCheckBegin)Del);
		}
		else
		{
			_MultiCastDel = (Del_SweepCheckBegin)Delegate.Remove(_MultiCastDel, (Del_SweepCheckBegin)Del);
		}
	}

	public static GSDel_SweepCheckBegin operator +(GSDel_SweepCheckBegin GSEvent, Del_SweepCheckBegin Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			bool flag = entityComponent.IsNetActive();
			orAllocEventRegCache.Add(EventRegCache.AllocEventRegCache(GSEvent.EventId, Del, flag));
			if (!flag)
			{
				return GSEvent;
			}
		}
		GSEvent._MultiCastDel = (Del_SweepCheckBegin)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_SweepCheckBegin operator -(GSDel_SweepCheckBegin GSEvent, Del_SweepCheckBegin Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SweepCheckBegin == Del)
				{
					EventRegCache.DeAllocEventRegCache(orAllocEventRegCache[num]);
					orAllocEventRegCache.RemoveAt(num);
				}
			}
			if (orAllocEventRegCache.Count == 0)
			{
				GSEvent._OwnerEventCollectionCS.DeAllocEventRegCache(entityComponent);
			}
			if (!entityComponent.IsNetActive())
			{
				return GSEvent;
			}
		}
		GSEvent._MultiCastDel = (Del_SweepCheckBegin)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int NotifyID, int WeaponIndex, List<FUStCheckShape> SweepCheckShape, List<int> EffectIDList, List<AbnormalStateAccConfig> AbnormalStateEffectList, List<int> EffectIDListForSceneItem, FHitDestructibleActorConfig HitDestructibleActorConfig, int HitChrAudioID, int HitChrFXWeight, FHitCheckConf HitCheckConf, bool CanHitBackBullet, float SweepCheckProtectTime, UAnimSequenceBase Animation, UAnimMontage AtkReboundingAM, UAnimMontage LowAtkRebounding, int SweepCheckGroupID, int FromInstanceID, List<FTriggerEffectWithCondition> EffectsWithCondition_Before, List<FTriggerEffectWithCondition> EffectsWithCondition_After, float NotifyBeginTime)
	{
		_MultiCastDel?.Invoke(NotifyID, WeaponIndex, SweepCheckShape, EffectIDList, AbnormalStateEffectList, EffectIDListForSceneItem, HitDestructibleActorConfig, HitChrAudioID, HitChrFXWeight, HitCheckConf, CanHitBackBullet, SweepCheckProtectTime, Animation, AtkReboundingAM, LowAtkRebounding, SweepCheckGroupID, FromInstanceID, EffectsWithCondition_Before, EffectsWithCondition_After, NotifyBeginTime);
	}
}
