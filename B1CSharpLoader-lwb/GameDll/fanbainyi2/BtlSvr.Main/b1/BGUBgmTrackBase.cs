using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;

namespace b1;

public class BGUBgmTrackBase : IBGUBgmTrack
{
	protected BGS_GameBgmMgr GameBgmMgr;

	protected bool IsCanTick;

	public BGUBgmTrackBase(BGS_GameBgmMgr GameBgmMgr)
	{
		this.GameBgmMgr = GameBgmMgr;
		IsCanTick = true;
	}

	public AActor GetOwner()
	{
		return GameBgmMgr.GetOwner();
	}

	public virtual void TryPlayBGM(BGMWrap NewBGMWrap)
	{
	}

	public virtual void TryStopBGM(Entity RequestorEntity, EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
	}

	public virtual void PauseBGM(EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
	}

	public virtual void ResumeBGM()
	{
	}

	public void Tick(float DeltaTime)
	{
		if (IsCanTick)
		{
			OnTick(DeltaTime);
		}
	}

	protected virtual void OnTick(float DeltaTime)
	{
	}

	public virtual void OnShutdown()
	{
	}

	public virtual void OnReset(EResetActorReason ResetReason)
	{
	}

	public int PostEventWithWrap(UAkAudioEvent AkEvent, BGMWrap Wrap, int CallbackMask, FOnAkPostEventCallback PostEventCallback, List<FAkExternalSourceInfo> ExternalSources, bool bStopWhenAttachedToDestroyed = false, string EventName = null)
	{
		return GameBgmMgr.PostEventWithWrap(AkEvent, Wrap, CallbackMask, PostEventCallback, ExternalSources, bStopWhenAttachedToDestroyed, EventName);
	}

	public int PostStopEvent(UAkAudioEvent AkEvent, BGMWrap Wrap, int CallbackMask, FOnAkPostEventCallback PostEventCallback, List<FAkExternalSourceInfo> ExternalSources, bool bStopWhenAttachedToDestroyed = false, string EventName = null)
	{
		return GameBgmMgr.PostStopEvent(AkEvent, Wrap, CallbackMask, PostEventCallback, ExternalSources, bStopWhenAttachedToDestroyed, EventName);
	}

	public void SetIsCanTick(bool NewIsCanTick)
	{
		IsCanTick = NewIsCanTick;
	}
}
