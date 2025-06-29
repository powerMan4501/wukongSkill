using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_EnvironmentInteractionMgrData : IBUC_EnvironmentInteractionMgrData, IPersistentECSData
{
	public int MaxLineTraceCount = 10;

	public bool bNearGround { get; set; }

	public ESceneItemSurfaceType OriginalSurfaceType { get; set; }

	public ESceneItemSurfaceType EnvironmentOverrideSurfaceType { get; set; }

	public ESceneItemSurfaceType ResultSurfaceType { get; set; }

	public ESceneItemSurfaceType SamplePointResultSurfaceType { get; set; }

	public ESceneItemSurfaceType LastResultSurfaceType { get; set; }

	public FVector SurfaceNormal_Normalized { get; set; }

	public FRotator ChrRotAlignSurface { get; set; }

	public FVector SurfaceHitPoint { get; set; }

	public FVector PhySurfaceHitPoint { get; set; }

	public int LineTraceCount { get; set; }

	public int LastSurfaceEffectID { get; set; }

	public float EnvironmentAbnormalEffectApplyTimer { get; set; }

	public List<EBGUSimpleState> LastDisableAutoRecoverSSList { get; set; }

	public Dictionary<EAbnormalStateType, float> AbnormalStateAutoRecoverRateMap { get; set; }

	public BUC_EnvironmentInteractionMgrData()
	{
		EnvironmentOverrideSurfaceType = ESceneItemSurfaceType.DefaultSurface;
		LastSurfaceEffectID = -1;
		LastDisableAutoRecoverSSList = new List<EBGUSimpleState>();
		AbnormalStateAutoRecoverRateMap = new Dictionary<EAbnormalStateType, float>();
	}

	public void ClearLastDisableAutoRecoverSimpleStates(AActor Target)
	{
		foreach (EBGUSimpleState lastDisableAutoRecoverSS in LastDisableAutoRecoverSSList)
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(Target, lastDisableAutoRecoverSS, IsRemove: true);
		}
		LastDisableAutoRecoverSSList.Clear();
	}

	public void ResetLastAutoRecoverRate()
	{
		AbnormalStateAutoRecoverRateMap.Clear();
	}

	public float GetAbnormalStateAutoRecoverRate(EAbnormalStateType AbnormalStateType)
	{
		if (AbnormalStateAutoRecoverRateMap.TryGetValue(AbnormalStateType, out var value))
		{
			return value;
		}
		return 1f;
	}
}
