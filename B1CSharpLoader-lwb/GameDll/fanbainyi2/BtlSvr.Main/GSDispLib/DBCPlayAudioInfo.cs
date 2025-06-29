using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPlayAudioInfo : DBCPauseableEventInfo
{
	public BUC_DispLibDBC_PlayAudio SourceRequest;

	public List<DBCAdvProcessScalarParam> RTPC;

	public int WWiseID;

	public bool HasSpawn;

	public DispLibDBCEndMode EndMode;

	public int ForceAudioMute { get; set; } = -1;

	public bool NeedCalRootBoneVelocity { get; protected set; }

	public void DBCInfoInit(uint _IdentityID, float CurTime, BUC_DispLibDBC_PlayAudio _SourceRequest, USceneComponent _SourceDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		base.IdentityID = _IdentityID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _SourceRequest;
		PlayAtTime = CurTime + _SourceRequest.Delay;
		WWiseID = -1;
		ForceAudioMute = -1;
		PausePriority = SourceRequest.PausePriority;
		EndMode = _SourceRequest.EndMode;
		if (EndMode == DispLibDBCEndMode.FixDuration)
		{
			EndAtTime = PlayAtTime + SourceRequest.Duration;
		}
		else
		{
			EndAtTime = -1f;
		}
		if (EndMode == DispLibDBCEndMode.AutoRelease)
		{
			EndMode = DispLibDBCEndMode.FixDuration;
			EndAtTime = PlayAtTime + 8f;
		}
		RTPC = null;
		List<BUC_DispLibUtil_DBCAdvProcessScalarParam> rTPC = SourceRequest.RTPC;
		if (rTPC == null || rTPC.Count == 0)
		{
			return;
		}
		RTPC = new List<DBCAdvProcessScalarParam>();
		for (int i = 0; i < rTPC.Count; i++)
		{
			if (rTPC[i].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || rTPC[i].NeedVelocity();
				DBCAdvProcessScalarParam item = new DBCAdvProcessScalarParam(rTPC[i].ParamName, rTPC[i].ProcessValue, 0f);
				RTPC.Add(item);
			}
		}
	}

	public bool DBCInfoInitFromAbstractEvent(DBCAbstractEventInfo AbstractEvent, float CurTime, BUC_DispLibDBC_PlayAudio _RealRequest)
	{
		SourceRequest = _RealRequest;
		float delay = SourceRequest.Delay;
		PlayAtTime = AbstractEvent.AbstractEventStartAtTime + delay;
		ForceAudioMute = AbstractEvent.ForceAudioMute;
		EndMode = SourceRequest.EndMode;
		if (EndMode == DispLibDBCEndMode.FixDuration)
		{
			EndAtTime = PlayAtTime + SourceRequest.Duration;
		}
		else
		{
			EndAtTime = -1f;
		}
		if (EndMode == DispLibDBCEndMode.AutoRelease)
		{
			EndMode = DispLibDBCEndMode.FixDuration;
			EndAtTime = PlayAtTime + 8f;
		}
		if (EndMode == DispLibDBCEndMode.FixDuration && CurTime > EndAtTime)
		{
			return false;
		}
		base.IsPause = false;
		base.PauseAtTime = 0f;
		base.PauseRequestOperationCounter = 0;
		DBCInfoInit(AbstractEvent.SourceDispOwnerComp);
		base.IdentityID = AbstractEvent.IdentityID;
		base.AnimNotifyUniqueID = AbstractEvent.AnimNotifyUniqueID;
		base.MontageUniqueID = AbstractEvent.MontageUniqueID;
		WWiseID = -1;
		PausePriority = SourceRequest.PausePriority;
		RTPC = null;
		float startAge = AbstractEvent.AbstractEventGameAge - delay;
		List<BUC_DispLibUtil_DBCAdvProcessScalarParam> rTPC = SourceRequest.RTPC;
		if (rTPC != null && rTPC.Count != 0)
		{
			RTPC = new List<DBCAdvProcessScalarParam>();
			for (int i = 0; i < rTPC.Count; i++)
			{
				if (rTPC[i].IsValid())
				{
					NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || rTPC[i].NeedVelocity();
					DBCAdvProcessScalarParam item = new DBCAdvProcessScalarParam(rTPC[i].ParamName, rTPC[i].ProcessValue, startAge);
					RTPC.Add(item);
				}
			}
		}
		return true;
	}

	public override bool CheckHasTag(FName Tag)
	{
		return false;
	}

	public bool CheckValid()
	{
		if (base.SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}
}
