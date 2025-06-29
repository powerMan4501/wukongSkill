using b1.ECS;

namespace b1;

public class BUC_UnitHitVEffectData : IBUC_UnitHitVEffectData, IPersistentECSData
{
	public float BeAttackedDelayTriggerFreezeFrameTimer;

	public float FreezeFrameGapCache;

	public float FreezeFrameTimeCache;

	public bool IsTriggerFreezeFrameEnable;

	private float LastFreezeFrameStartTimeMark;

	private float FreezeFrameDuration;

	private float FreezeFrameGap;

	private float LastHitCameraShakeStartTimeMark;

	private float CameraShakeGap;

	public UnorderedDict<int, float> SweepSceneItemGapDic;

	public uint PauseAnimsHandleID;

	public ESlowIKType SlowIKType { get; set; }

	public float SlowTime { get; set; }

	public float SlowTime_Crit { get; set; }

	public float SlowIK_ProtectGap { get; set; }

	public BUC_UnitHitVEffectData()
	{
		LastFreezeFrameStartTimeMark = -1f;
		SweepSceneItemGapDic = new UnorderedDict<int, float>();
		SlowIKType = ESlowIKType.None;
		SlowTime = -1f;
	}

	public void MarkFreezeFrame(float TotalFreezeTime, float CurTimeInSeconds)
	{
		LastFreezeFrameStartTimeMark = CurTimeInSeconds;
		FreezeFrameDuration = TotalFreezeTime;
	}

	public bool UnFreezeFrameTimeMark(float CurTimeInSeconds)
	{
		if (LastFreezeFrameStartTimeMark != -1f && LastFreezeFrameStartTimeMark + FreezeFrameDuration <= CurTimeInSeconds)
		{
			FreezeFrameDuration = 0f;
			return true;
		}
		return false;
	}

	public void UpdateFreezeFrameGap(float InFreezeFrameGap)
	{
		if (FreezeFrameGap == 0f)
		{
			FreezeFrameGap = InFreezeFrameGap;
		}
	}

	public void ResetFreezeFrameGap()
	{
		FreezeFrameGap = 0f;
	}

	public void ResetFreezeFrameStartTimeMark()
	{
		LastFreezeFrameStartTimeMark = -1f;
	}

	public bool CheckIsInFreezeFrameGap(float CurTimeInSeconds)
	{
		if (LastFreezeFrameStartTimeMark != -1f && LastFreezeFrameStartTimeMark + FreezeFrameGap > CurTimeInSeconds)
		{
			return true;
		}
		return false;
	}

	public bool CheckIsInFreezeFrame(float CurTimeInSeconds)
	{
		if (LastFreezeFrameStartTimeMark != -1f && LastFreezeFrameStartTimeMark + FreezeFrameDuration > CurTimeInSeconds)
		{
			return true;
		}
		return false;
	}

	public void MarkHitCameraShake(float CurTimeInSeconds)
	{
		LastHitCameraShakeStartTimeMark = CurTimeInSeconds;
	}

	public void UpdateCameraShakeGap(float InCameraShakeGap)
	{
		if (CameraShakeGap == 0f)
		{
			CameraShakeGap = InCameraShakeGap;
		}
	}

	public void ResetCameraShakeGap()
	{
		CameraShakeGap = 0f;
	}

	public bool CheckCanPlayHitCameraShake(float CurTimeInSeconds)
	{
		if (LastHitCameraShakeStartTimeMark == 0f || LastHitCameraShakeStartTimeMark + CameraShakeGap < CurTimeInSeconds)
		{
			return true;
		}
		return false;
	}

	public bool IsInSweepSceneItemGap(int ObjectID)
	{
		if (SweepSceneItemGapDic.Find(ObjectID, out var _))
		{
			return false;
		}
		return true;
	}

	public void MarkSweepSceneItemProtect(int ObjectID, float ProtectTime)
	{
		SweepSceneItemGapDic.Set(ObjectID, ProtectTime);
	}

	public bool CanTriggerSlowIK()
	{
		if (SlowIKType == ESlowIKType.None || SlowTime <= 0f)
		{
			return false;
		}
		return true;
	}

	public void MarkSlowIKProtectGap(float ProtectGap, float CurTimeInSeconds)
	{
		if (ProtectGap > 0f)
		{
			LastFreezeFrameStartTimeMark = CurTimeInSeconds;
			FreezeFrameGap = ProtectGap;
		}
	}
}
