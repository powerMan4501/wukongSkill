using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_BeginForSetCurveValueToMesh : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BeginForSetCurveValueToMesh _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BeginForSetCurveValueToMesh)Delegate.Combine(_MultiCastDel, (Del_BeginForSetCurveValueToMesh)Del);
		}
		else
		{
			_MultiCastDel = (Del_BeginForSetCurveValueToMesh)Delegate.Remove(_MultiCastDel, (Del_BeginForSetCurveValueToMesh)Del);
		}
	}

	public static GSDel_BeginForSetCurveValueToMesh operator +(GSDel_BeginForSetCurveValueToMesh GSEvent, Del_BeginForSetCurveValueToMesh Del)
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
		GSEvent._MultiCastDel = (Del_BeginForSetCurveValueToMesh)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_BeginForSetCurveValueToMesh operator -(GSDel_BeginForSetCurveValueToMesh GSEvent, Del_BeginForSetCurveValueToMesh Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BeginForSetCurveValueToMesh == Del)
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
		GSEvent._MultiCastDel = (Del_BeginForSetCurveValueToMesh)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int NotifyInstID, TArrayReadWrite<FGSFloatCurveToParam> FloatCurveParamList, TArrayReadWrite<FGSLinearColorCurveToParam> LinearColorCurveParamList, bool NotApplyToChrMesh, TArrayReadWrite<int> MatIndexList, bool BothWeapons, TArrayReadWrite<int> WeaponIndexList, TArrayReadWrite<int> WeaponMatIndexList, bool BothChildSkeltalMeshes, TArrayReadWrite<FName> ChildSKMeshTagList, TArrayReadWrite<int> ChildSKMatIndexList, bool BothChildActor, TArrayReadWrite<int> ChildActorMeshMatIndexList, float TotalDuration, bool bFitRealTime)
	{
		_MultiCastDel?.Invoke(NotifyInstID, FloatCurveParamList, LinearColorCurveParamList, NotApplyToChrMesh, MatIndexList, BothWeapons, WeaponIndexList, WeaponMatIndexList, BothChildSkeltalMeshes, ChildSKMeshTagList, ChildSKMatIndexList, BothChildActor, ChildActorMeshMatIndexList, TotalDuration, bFitRealTime);
	}
}
