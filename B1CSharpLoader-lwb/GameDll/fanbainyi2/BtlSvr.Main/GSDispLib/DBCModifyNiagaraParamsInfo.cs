using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCModifyNiagaraParamsInfo : DBCPauseableEventInfoBase
{
	public bool HasSpawn;

	public int EndStagePriority;

	public bool OnEndDispStage;

	public float EndStageStartTime;

	public float GameAge;

	public DispLibDBCModNiagaraParamsPauseMode PauseMode;

	public BUC_DispLibDBC_EntityEffectTargetInfo MeshCompFilterInfo;

	public BUC_DispLibDBC_ModifyNiagaraTargetInfo NiagaraCompFilterInfo;

	public DispLibDBCEndMode EndMode;

	public List<ModifyNiagaraParamsBoolParamInfo> BoolParamsInfo;

	public List<ModifyNiagaraParamsFloatParamInfo> FloatParamsInfo;

	public List<ModifyNiagaraParamsFloatParamInfo> Int32ParamsInfo;

	public List<ModifyNiagaraParamsFVectorParamInfo> FVectorParamsInfo;

	public List<ModifyNiagaraParamsFLinearColorParamInfo> FLinearColorParamsInfo;

	public BUC_DispLibDBC_ModifyNiagaraParams SourceRequest { get; set; }

	public float DelayTimeAfterStop { get; private set; }

	public bool NeedCalRootBoneVelocity { get; protected set; }

	public bool HasAnyEveryFrameSetArrayParam { get; private set; }

	public override bool CheckHasTag(FName Tag)
	{
		return false;
	}

	public bool DBCInfoInitFromAbstractEvent(DBCAbstractEventInfo AbstractEvent, float CurTime, BUC_DispLibDBC_ModifyNiagaraParams _RealRequest)
	{
		SourceRequest = _RealRequest;
		float delay = SourceRequest.Delay;
		GameAge = 0f;
		PlayAtTime = AbstractEvent.AbstractEventStartAtTime + delay;
		DelayTimeAfterStop = SourceRequest.DelayTimeAfterStop;
		EndMode = SourceRequest.EndMode;
		if (EndMode != DispLibDBCEndMode.ProcedureNotity)
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
		EndStageStartTime = EndAtTime;
		if (EndMode == DispLibDBCEndMode.FixDuration && CurTime > EndAtTime)
		{
			return false;
		}
		base.IsPause = false;
		base.PauseAtTime = 0f;
		base.PauseRequestOperationCounter = 0;
		DBCInfoInit(AbstractEvent.SourceDispOwnerComp);
		HasSpawn = false;
		OnEndDispStage = false;
		base.IdentityID = AbstractEvent.IdentityID;
		base.AnimNotifyUniqueID = AbstractEvent.AnimNotifyUniqueID;
		base.MontageUniqueID = AbstractEvent.MontageUniqueID;
		MeshCompFilterInfo = SourceRequest.MeshCompFilterInfo;
		NiagaraCompFilterInfo = SourceRequest.NiagaraCompFilterInfo;
		PausePriority = SourceRequest.PausePriority;
		EndStagePriority = SourceRequest.EndStagePriority;
		List<BUC_DispLibUtil_ModNiagara_NameAndBoolValue> setBoolParam = SourceRequest.SetBoolParam;
		List<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam> setFloatParam = SourceRequest.SetFloatParam;
		List<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam> setInt32Param = SourceRequest.SetInt32Param;
		List<BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam> setFVectorParam = SourceRequest.SetFVectorParam;
		List<BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam> setFLinearColorParam = SourceRequest.SetFLinearColorParam;
		BoolParamsInfo = new List<ModifyNiagaraParamsBoolParamInfo>();
		FloatParamsInfo = new List<ModifyNiagaraParamsFloatParamInfo>();
		Int32ParamsInfo = new List<ModifyNiagaraParamsFloatParamInfo>();
		FVectorParamsInfo = new List<ModifyNiagaraParamsFVectorParamInfo>();
		FLinearColorParamsInfo = new List<ModifyNiagaraParamsFLinearColorParamInfo>();
		NeedCalRootBoneVelocity = false;
		FVector dispRootBoneVelocity = BGU_DispLibDataUtil.GetDispRootBoneVelocity(base.SourceDispOwnerComp);
		float startAge = AbstractEvent.AbstractEventGameAge - delay;
		for (int i = 0; i < setBoolParam.Count; i++)
		{
			if (setBoolParam[i].IsValid())
			{
				BoolParamsInfo.Add(new ModifyNiagaraParamsBoolParamInfo(setBoolParam[i], startAge));
			}
		}
		for (int j = 0; j < setFloatParam.Count; j++)
		{
			if (setFloatParam[j].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setFloatParam[j].NeedVelocity();
				FloatParamsInfo.Add(new ModifyNiagaraParamsFloatParamInfo(setFloatParam[j], dispRootBoneVelocity, startAge));
			}
		}
		for (int k = 0; k < setInt32Param.Count; k++)
		{
			if (setInt32Param[k].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setInt32Param[k].NeedVelocity();
				Int32ParamsInfo.Add(new ModifyNiagaraParamsFloatParamInfo(setInt32Param[k], dispRootBoneVelocity, startAge));
			}
		}
		for (int l = 0; l < setFVectorParam.Count; l++)
		{
			if (setFVectorParam[l].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setFVectorParam[l].NeedVelocity();
				FVectorParamsInfo.Add(new ModifyNiagaraParamsFVectorParamInfo(setFVectorParam[l], dispRootBoneVelocity, startAge));
			}
		}
		for (int m = 0; m < setFLinearColorParam.Count; m++)
		{
			if (setFLinearColorParam[m].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setFLinearColorParam[m].NeedVelocity();
				FLinearColorParamsInfo.Add(new ModifyNiagaraParamsFLinearColorParamInfo(setFLinearColorParam[m], dispRootBoneVelocity, startAge));
			}
		}
		HasAnyEveryFrameSetArrayParam = false;
		for (int n = 0; n < SourceRequest.SetFloatArrayParam.Count; n++)
		{
			if (SourceRequest.SetFloatArrayParam[n].IsValid())
			{
				HasAnyEveryFrameSetArrayParam |= SourceRequest.SetFloatArrayParam[n].SetEveryFrame;
			}
		}
		for (int num = 0; num < SourceRequest.SetInt32ArrayParam.Count; num++)
		{
			if (SourceRequest.SetInt32ArrayParam[num].IsValid())
			{
				HasAnyEveryFrameSetArrayParam |= SourceRequest.SetInt32ArrayParam[num].SetEveryFrame;
			}
		}
		for (int num2 = 0; num2 < SourceRequest.SetFVectorArrayParam.Count; num2++)
		{
			if (SourceRequest.SetFVectorArrayParam[num2].IsValid())
			{
				HasAnyEveryFrameSetArrayParam |= SourceRequest.SetFVectorArrayParam[num2].SetEveryFrame;
			}
		}
		return true;
	}

	public void DBCInfoInit(float CurTime, uint _IdentityID, BUC_DispLibDBC_ModifyNiagaraParams _Request, USceneComponent _SourceDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		HasSpawn = false;
		OnEndDispStage = false;
		base.IdentityID = _IdentityID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _Request;
		DelayTimeAfterStop = _Request.DelayTimeAfterStop;
		MeshCompFilterInfo = SourceRequest.MeshCompFilterInfo;
		NiagaraCompFilterInfo = SourceRequest.NiagaraCompFilterInfo;
		EndMode = SourceRequest.EndMode;
		PlayAtTime = CurTime + SourceRequest.Delay;
		GameAge = 0f;
		NeedCalRootBoneVelocity = false;
		if (EndMode != DispLibDBCEndMode.ProcedureNotity)
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
		EndStageStartTime = EndAtTime;
		PausePriority = SourceRequest.PausePriority;
		EndStagePriority = SourceRequest.EndStagePriority;
		List<BUC_DispLibUtil_ModNiagara_NameAndBoolValue> setBoolParam = SourceRequest.SetBoolParam;
		List<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam> setFloatParam = SourceRequest.SetFloatParam;
		List<BUC_DispLibUtil_ModifyNiagaraParams_FloatParam> setInt32Param = SourceRequest.SetInt32Param;
		List<BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam> setFVectorParam = SourceRequest.SetFVectorParam;
		List<BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam> setFLinearColorParam = SourceRequest.SetFLinearColorParam;
		BoolParamsInfo = new List<ModifyNiagaraParamsBoolParamInfo>();
		FloatParamsInfo = new List<ModifyNiagaraParamsFloatParamInfo>();
		Int32ParamsInfo = new List<ModifyNiagaraParamsFloatParamInfo>();
		FVectorParamsInfo = new List<ModifyNiagaraParamsFVectorParamInfo>();
		FLinearColorParamsInfo = new List<ModifyNiagaraParamsFLinearColorParamInfo>();
		FVector dispRootBoneVelocity = BGU_DispLibDataUtil.GetDispRootBoneVelocity(base.SourceDispOwnerComp);
		for (int i = 0; i < setBoolParam.Count; i++)
		{
			if (setBoolParam[i].IsValid())
			{
				BoolParamsInfo.Add(new ModifyNiagaraParamsBoolParamInfo(setBoolParam[i], 0f));
			}
		}
		for (int j = 0; j < setFloatParam.Count; j++)
		{
			if (setFloatParam[j].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setFloatParam[j].NeedVelocity();
				FloatParamsInfo.Add(new ModifyNiagaraParamsFloatParamInfo(setFloatParam[j], dispRootBoneVelocity, 0f));
			}
		}
		for (int k = 0; k < setInt32Param.Count; k++)
		{
			if (setInt32Param[k].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setInt32Param[k].NeedVelocity();
				Int32ParamsInfo.Add(new ModifyNiagaraParamsFloatParamInfo(setInt32Param[k], dispRootBoneVelocity, 0f));
			}
		}
		for (int l = 0; l < setFVectorParam.Count; l++)
		{
			if (setFVectorParam[l].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setFVectorParam[l].NeedVelocity();
				FVectorParamsInfo.Add(new ModifyNiagaraParamsFVectorParamInfo(setFVectorParam[l], dispRootBoneVelocity, 0f));
			}
		}
		for (int m = 0; m < setFLinearColorParam.Count; m++)
		{
			if (setFLinearColorParam[m].IsValid())
			{
				NeedCalRootBoneVelocity = NeedCalRootBoneVelocity || setFLinearColorParam[m].NeedVelocity();
				FLinearColorParamsInfo.Add(new ModifyNiagaraParamsFLinearColorParamInfo(setFLinearColorParam[m], dispRootBoneVelocity, 0f));
			}
		}
		HasAnyEveryFrameSetArrayParam = false;
		for (int n = 0; n < SourceRequest.SetFloatArrayParam.Count; n++)
		{
			if (SourceRequest.SetFloatArrayParam[n].IsValid())
			{
				HasAnyEveryFrameSetArrayParam |= SourceRequest.SetFloatArrayParam[n].SetEveryFrame;
			}
		}
		for (int num = 0; num < SourceRequest.SetInt32ArrayParam.Count; num++)
		{
			if (SourceRequest.SetInt32ArrayParam[num].IsValid())
			{
				HasAnyEveryFrameSetArrayParam |= SourceRequest.SetInt32ArrayParam[num].SetEveryFrame;
			}
		}
		for (int num2 = 0; num2 < SourceRequest.SetFVectorArrayParam.Count; num2++)
		{
			if (SourceRequest.SetFVectorArrayParam[num2].IsValid())
			{
				HasAnyEveryFrameSetArrayParam |= SourceRequest.SetFVectorArrayParam[num2].SetEveryFrame;
			}
		}
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
