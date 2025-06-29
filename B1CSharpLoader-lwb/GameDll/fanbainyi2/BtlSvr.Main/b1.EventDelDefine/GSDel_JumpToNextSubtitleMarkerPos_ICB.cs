using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;

namespace b1.EventDelDefine;

public class GSDel_JumpToNextSubtitleMarkerPos_ICB : IFreshAbleGSEvent
{
	private Del_JumpToNextSubtitleMarkerPos _InvokeCallBack;

	private Action<Del_JumpToNextSubtitleMarkerPos> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_JumpToNextSubtitleMarkerPos _MultiCastDel;

	public GSDel_JumpToNextSubtitleMarkerPos_ICB(Del_JumpToNextSubtitleMarkerPos InvokeCallBack, Action<Del_JumpToNextSubtitleMarkerPos> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_JumpToNextSubtitleMarkerPos)Delegate.Combine(_MultiCastDel, (Del_JumpToNextSubtitleMarkerPos)Del);
		}
		else
		{
			_MultiCastDel = (Del_JumpToNextSubtitleMarkerPos)Delegate.Remove(_MultiCastDel, (Del_JumpToNextSubtitleMarkerPos)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_JumpToNextSubtitleMarkerPos_ICB operator +(GSDel_JumpToNextSubtitleMarkerPos_ICB GSEvent, Del_JumpToNextSubtitleMarkerPos Del)
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
		GSEvent._MultiCastDel = (Del_JumpToNextSubtitleMarkerPos)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_JumpToNextSubtitleMarkerPos_ICB operator -(GSDel_JumpToNextSubtitleMarkerPos_ICB GSEvent, Del_JumpToNextSubtitleMarkerPos Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_JumpToNextSubtitleMarkerPos == Del)
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
		GSEvent._MultiCastDel = (Del_JumpToNextSubtitleMarkerPos)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string InEventName, UAkComponent AkComp, int PlayingID)
	{
		_InvokeCallBack?.Invoke(InEventName, AkComp, PlayingID);
	}
}
