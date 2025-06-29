using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_DoJumpAnim : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_DoJumpAnim _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_DoJumpAnim)Delegate.Combine(_MultiCastDel, (Del_DoJumpAnim)Del);
		}
		else
		{
			_MultiCastDel = (Del_DoJumpAnim)Delegate.Remove(_MultiCastDel, (Del_DoJumpAnim)Del);
		}
	}

	public static GSDel_DoJumpAnim operator +(GSDel_DoJumpAnim GSEvent, Del_DoJumpAnim Del)
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
		GSEvent._MultiCastDel = (Del_DoJumpAnim)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_DoJumpAnim operator -(GSDel_DoJumpAnim GSEvent, Del_DoJumpAnim Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_DoJumpAnim == Del)
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
		GSEvent._MultiCastDel = (Del_DoJumpAnim)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(bool bIsJumping, ESkillDirection StartJumpDir = ESkillDirection.None, EStartJumpSpdState StartJumpSpdState = EStartJumpSpdState.StartJumpSpdState_Zero, EJumpType JumpType = EJumpType.Normal)
	{
		_MultiCastDel?.Invoke(bIsJumping, StartJumpDir, StartJumpSpdState, JumpType);
	}
}
