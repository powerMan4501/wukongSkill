using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_EnvironmentMaskData : IBUC_EnvironmentMaskData
{
	public Dictionary<ESceneItemSurfaceType, float> PendingFadeTargetData = new Dictionary<ESceneItemSurfaceType, float>();

	public Dictionary<FName, Dictionary<FName, int>> GamePlayDispReqIDCache = new Dictionary<FName, Dictionary<FName, int>>();

	public bool bShouldTick = true;

	public bool bInPhotoMode;

	public float NotifyEndDBCTimer;

	public bool bStartEndDBCTimerCountdown;

	public Dictionary<ESceneItemSurfaceType, float> AccumulatedMaskData { get; set; }

	public BUC_EnvironmentMaskData()
	{
		AccumulatedMaskData = new Dictionary<ESceneItemSurfaceType, float>();
		ResetNotifyEndDBCTimer();
	}

	public void ResetNotifyEndDBCTimer()
	{
		NotifyEndDBCTimer = 10f;
	}

	public float ModifyAccumulatedValue(ESceneItemSurfaceType SurfaceType, float DeltaValue, float MinValue, float MaxValue)
	{
		float num = AccumulatedMaskData[SurfaceType];
		num += DeltaValue;
		num = FMath.Clamp(num, MinValue, MaxValue);
		AccumulatedMaskData[SurfaceType] = num;
		return num;
	}
}
