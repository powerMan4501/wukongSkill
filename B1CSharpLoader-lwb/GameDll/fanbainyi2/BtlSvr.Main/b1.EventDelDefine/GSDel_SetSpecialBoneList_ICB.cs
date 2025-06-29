using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetSpecialBoneList_ICB : IFreshAbleGSEvent
{
	private Del_SetSpecialBoneList _InvokeCallBack;

	private Action<Del_SetSpecialBoneList> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetSpecialBoneList _MultiCastDel;

	public GSDel_SetSpecialBoneList_ICB(Del_SetSpecialBoneList InvokeCallBack, Action<Del_SetSpecialBoneList> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetSpecialBoneList)Delegate.Combine(_MultiCastDel, (Del_SetSpecialBoneList)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetSpecialBoneList)Delegate.Remove(_MultiCastDel, (Del_SetSpecialBoneList)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetSpecialBoneList_ICB operator +(GSDel_SetSpecialBoneList_ICB GSEvent, Del_SetSpecialBoneList Del)
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
		GSEvent._MultiCastDel = (Del_SetSpecialBoneList)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetSpecialBoneList_ICB operator -(GSDel_SetSpecialBoneList_ICB GSEvent, Del_SetSpecialBoneList Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetSpecialBoneList == Del)
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
		GSEvent._MultiCastDel = (Del_SetSpecialBoneList)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(BGWDataAsset_SpecialBoneConfig InSpecialBoneConfig)
	{
		_InvokeCallBack?.Invoke(InSpecialBoneConfig);
	}
}
