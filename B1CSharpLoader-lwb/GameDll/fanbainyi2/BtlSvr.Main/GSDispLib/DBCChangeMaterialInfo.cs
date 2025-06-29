using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCChangeMaterialInfo : DBCPauseableEventInfo
{
	public bool HasSpawn;

	public uint ChangeMatEventID;

	public bool OnEndDispStage;

	public float EndStageStartTime;

	public int EndStagePriority;

	public BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode;

	public int Priority;

	public DispLibDBCEndMode EndMode;

	public DispLibMaterialParamsInheritMode InheriParamsMode;

	public List<BUC_DispLibUtil_NameAndScalarCurve> SetCurveScalarParam;

	public List<BUC_DispLibUtil_NameAndLColorCurve> SetCurveLColorParam;

	public List<BUC_DispLibUtil_NameAndVectorCurve> SetCurveV3Param;

	public List<BUC_DispLibUtil_PCurve_NameAndScalar> EndStage_SetPCurveScalarParam;

	public List<BUC_DispLibUtil_PCurve_NameAndLColor> EndStage_SetPCurveLColorParam;

	public BUC_DispLibDBC_ChangeMaterial SourceRequest { get; set; }

	public float DelayTimeAfterStop { get; private set; }

	public void DBCInfoInit(float CurTime, uint _IdentityID, BUC_DispLibDBC_ChangeMaterial _Request, USceneComponent _SourceDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		HasSpawn = false;
		OnEndDispStage = false;
		base.IdentityID = _IdentityID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _Request;
		DelayTimeAfterStop = _Request.DelayTimeAfterStop;
		InheriParamsMode = SourceRequest.InheriParamsMode;
		Priority = 0;
		FilterMode = SourceRequest.FilterMode;
		EndMode = SourceRequest.EndMode;
		PlayAtTime = CurTime + SourceRequest.Delay;
		if (EndMode != DispLibDBCEndMode.ProcedureNotity)
		{
			EndAtTime = PlayAtTime + SourceRequest.Duration;
		}
		else
		{
			EndAtTime = -1f;
		}
		EndStageStartTime = EndAtTime;
		EndStagePriority = SourceRequest.EndStagePriority;
		SetCurveScalarParam = SourceRequest.SetCurveScalarParam;
		SetCurveLColorParam = SourceRequest.SetCurveLColorParam;
		SetCurveV3Param = SourceRequest.SetCurveV3Param;
		EndStage_SetPCurveScalarParam = SourceRequest.EndStage_SetPCurveScalarParam;
		EndStage_SetPCurveLColorParam = SourceRequest.EndStage_SetPCurveLColorParam;
	}

	public override bool CheckHasTag(FName Tag)
	{
		return false;
	}
}
